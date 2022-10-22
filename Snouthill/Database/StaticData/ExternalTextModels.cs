using Snouthill.Database.Models;

namespace Snouthill.Database.StaticData;

public class ExternalTextModels
{
    public static readonly IEnumerable<ExternalTextModel> Models = new List<ExternalTextModel>
    {
        new() {Key = "handitem1", Value = "Tea"},
        new() {Key = "handitem10", Value = "Latte"},
        new() {Key = "handitem11", Value = "Mocha"},
        new() {Key = "handitem12", Value = "Macchiato"},
        new() {Key = "handitem13", Value = "Espresso"},
        new() {Key = "handitem14", Value = "Filter"},
        new() {Key = "handitem15", Value = "Iced"},
        new() {Key = "handitem16", Value = "Cappuccino"},
        new() {Key = "handitem17", Value = "Java"},
        new() {Key = "handitem18", Value = "Tap"},
        new() {Key = "handitem19", Value = "Habbo Cola"},
        new() {Key = "handitem2", Value = "Juice"},
        new() {Key = "handitem20", Value = "Camera"},
        new() {Key = "handitem21", Value = "Hamburger"},
        new() {Key = "handitem22", Value = "Lime Habbo Soda"},
        new() {Key = "handitem23", Value = "Beetroot Habbo Soda"},
        new() {Key = "handitem24", Value = "Bubble juice from 1999"},
        new() {Key = "handitem25", Value = "Love potion"},
        new() {Key = "handitem3", Value = "Carrot"},
        new() {Key = "handitem4", Value = "Ice-cream"},
        new() {Key = "handitem5", Value = "Milk"},
        new() {Key = "handitem6", Value = "Blackcurrant"},
        new() {Key = "handitem7", Value = "Water"},
        new() {Key = "handitem8", Value = "Regular"},
        new() {Key = "handitem9", Value = "Decaff"},
        new() {Key = "modtool_rankerror", Value = "You do not have the rights for this action on this user!"},
        new() {Key = "player_commands_no_args", Value = "You have not supplied any arguments!"},
        new() {Key = "roomatic_givename", Value = "Give your room a name!"},
        new() {Key = "roomdimmer_furni_limit", Value = "You can only have one roomdimmer per room"},
        new() {Key = "room_sound_furni_limit", Value = "You can only place one sound furni per room"},
        new() {Key = "successfully_purchase_gift_for", Value = "Successfully purchased gift for user %user%!"}
    };
}