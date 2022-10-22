using System.Collections.Concurrent;
using Serilog;
using Snouthill.Networking.Messages.Moderation;

namespace Snouthill.Game;

public static class CallForHelpManager
{
    private const int EarmarkId = -1;
    private static int _lastId = 0;
    
    private static ConcurrentDictionary<int, CallForHelp> _callsForHelp = new();
    private static ConcurrentDictionary<string, int> _usersWithPendingCalls = new();

    public static bool SubmitCall(Player caller, string message)
    {
        if (!_usersWithPendingCalls.TryAdd(caller.Name, EarmarkId))
            return false;

        var id = Interlocked.Increment(ref _lastId);
        CallForHelp cfh = new(
            id,
            caller.Name,
            message,
            caller.Room?.Id,
            DateTimeOffset.Now.ToUnixTimeSeconds());
        
        if (!_callsForHelp.TryAdd(id, cfh))
            throw new InvalidOperationException("Could not add new CFH to map");
        if (!_usersWithPendingCalls.TryUpdate(caller.Name, id, EarmarkId))
            throw new InvalidOperationException("Could not replace earmarked CFH");
        
        caller.Send(new CryReceived());
        return true;
    }
    
    public static CallForHelp? GetPendingCallForPlayer(Player player)
    {
        if (!_usersWithPendingCalls.TryGetValue(player.Name, out var id))
            return null;

        if (id == EarmarkId)
        {
            Log.Error("Hit earmarked CFH");
            return null;
        }

        if (!_callsForHelp.TryGetValue(id, out var cfh))
            throw new InvalidOperationException("Could not find CFH");

        return cfh;
    }
}