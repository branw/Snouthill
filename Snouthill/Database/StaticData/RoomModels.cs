using Snouthill.Database.Models;

namespace Snouthill.Database.StaticData;

public class RoomModels
{
    public static readonly IEnumerable<RoomModel> Models = new List<RoomModel>
    {
        new()
        {
            Id = 1, Category = 3, Name = "Welcome Lounge", Description = "welcome_lounge",
            LayoutName = "newbie_lobby", FileNames = "hh_room_nlobby", MaxVisitors = 40
        },
        new()
        {
            Id = 2, Category = 3, Name = "Theatredome", Description = "theatredrome",
            LayoutName = "theater", FileNames = "hh_room_theater", MaxVisitors = 100
        },
        new()
        {
            Id = 3, Category = 3, Name = "Library", Description = "library",
            LayoutName = "library", FileNames = "hh_room_library", MaxVisitors = 30
        },
        new()
        {
            Id = 4, Category = 5, Name = "TV Studio", Description = "tv_studio",
            LayoutName = "tv_studio", FileNames = "hh_room_tv_studio_general", MaxVisitors = 20
        },
        new()
        {
            Id = 5, Category = 5, Name = "Cinema", Description = "habbo_cinema",
            LayoutName = "cinema_a", FileNames = "hh_room_cinema", MaxVisitors = 50
        },
        new()
        {
            Id = 6, Category = 5, Name = "Power Gym", Description = "sport",
            LayoutName = "sport", FileNames = "hh_room_sport", MaxVisitors = 35
        },
        new()
        {
            Id = 7, Category = 5, Name = "Olympic Stadium", Description = "ballroom",
            LayoutName = "ballroom", FileNames = "hh_room_ballroom", MaxVisitors = 50
        },
        new()
        {
            Id = 8, Category = 5, Name = "Habbo Kitchen", Description = "hotel_kitchen",
            LayoutName = "cr_kitchen", FileNames = "hh_room_kitchen", MaxVisitors = 20
        },
        new()
        {
            Id = 9, Category = 6, Name = "The Dirty Duck Pub", Description = "the_dirty_duck_pub",
            LayoutName = "pub_a", FileNames = "hh_room_pub", MaxVisitors = 40
        },
        new()
        {
            Id = 10, Category = 6, Name = "Cafe Ole", Description = "cafe_ole",
            LayoutName = "cafe_ole", FileNames = "hh_room_cafe", MaxVisitors = 35
        },
        new()
        {
            Id = 11, Category = 6, Name = "Gallery Cafe", Description = "eric\'s_eaterie",
            LayoutName = "cr_cafe", FileNames = "hh_room_erics", MaxVisitors = 35
        },
        new()
        {
            Id = 12, Category = 6, Name = "Space Cafe", Description = "space_cafe",
            LayoutName = "space_cafe", FileNames = "hh_room_space_cafe", MaxVisitors = 35
        },
        new()
        {
            Id = 13, Category = 7, Name = "Rooftop Terrace", Description = "rooftop",
            LayoutName = "rooftop", FileNames = "hh_room_rooftop", MaxVisitors = 30
        },
        new()
        {
            Id = 14, Category = 7, Name = "Rooftop Cafe", Description = "rooftop",
            LayoutName = "rooftop_2", FileNames = "hh_room_rooftop", MaxVisitors = 20, HideFromNavigator = true
        },
        new()
        {
            Id = 15, Category = 6, Name = "Palazzo Pizza", Description = "pizza",
            LayoutName = "pizza", FileNames = "hh_room_pizza", MaxVisitors = 40
        },
        new()
        {
            Id = 16, Category = 6, Name = "Habburgers", Description = "habburger\'s",
            LayoutName = "habburger", FileNames = "hh_room_habburger", MaxVisitors = 40
        },
        new()
        {
            Id = 17, Category = 8, Name = "Grandfathers Lounge", Description = "dusty_lounge",
            LayoutName = "dusty_lounge", FileNames = "hh_room_dustylounge", MaxVisitors = 45
        },
        new()
        {
            Id = 18, Category = 7, Name = "Oriental Tearoom", Description = "tearoom",
            LayoutName = "tearoom", FileNames = "hh_room_tearoom", MaxVisitors = 40
        },
        new()
        {
            Id = 19, Category = 7, Name = "Oldskool Lounge", Description = "old_skool",
            LayoutName = "old_skool0", FileNames = "hh_room_old_skool", MaxVisitors = 45
        },
        new()
        {
            Id = 20, Category = 7, Name = "Oldskool Dancefloor", Description = "old_skool",
            LayoutName = "old_skool1", FileNames = "hh_room_old_skool", MaxVisitors = 45, HideFromNavigator = true
        },
        new()
        {
            Id = 21, Category = 7, Name = "The Chromide Club", Description = "the_chromide_club",
            LayoutName = "malja_bar_a", FileNames = "hh_room_disco", MaxVisitors = 45
        },
        new()
        {
            Id = 22, Category = 7, Name = "The Chromide Club II", Description = "the_chromide_club",
            LayoutName = "malja_bar_b", FileNames = "hh_room_disco", MaxVisitors = 50, HideFromNavigator = true
        },
        new()
        {
            Id = 23, Category = 7, Name = "Club Massiva", Description = "club_massiva",
            LayoutName = "bar_a", FileNames = "hh_room_bar", MaxVisitors = 45
        },
        new()
        {
            Id = 24, Category = 7, Name = "Club Massiva II", Description = "club_massiva2",
            LayoutName = "bar_b", FileNames = "hh_room_bar", MaxVisitors = 70, HideFromNavigator = true
        },
        new()
        {
            Id = 25, Category = 6, Name = "Sunset Cafe", Description = "sunset_cafe",
            LayoutName = "sunset_cafe", FileNames = "hh_room_sunsetcafe", MaxVisitors = 35
        },
        new()
        {
            Id = 26, Category = 7, Name = "Oasis Spa", Description = "cafe_gold",
            LayoutName = "cafe_gold0", FileNames = "hh_room_gold", MaxVisitors = 50
        },
        new()
        {
            Id = 27, Category = 9, Name = "Treehugger Garden", Description = "chill",
            LayoutName = "chill", FileNames = "hh_room_chill", MaxVisitors = 30
        },
        new()
        {
            Id = 28, Category = 8, Name = "Club Mammoth", Description = "club_mammoth",
            LayoutName = "club_mammoth", FileNames = "hh_room_clubmammoth", MaxVisitors = 45
        },
        new()
        {
            Id = 29, Category = 9, Name = "Floating Garden", Description = "floatinggarden",
            LayoutName = "floatinggarden", FileNames = "hh_room_floatinggarden", MaxVisitors = 80
        },
        new()
        {
            Id = 30, Category = 9, Name = "Picnic Fields", Description = "picnic",
            LayoutName = "picnic", FileNames = "hh_room_picnic", MaxVisitors = 55
        },
        new()
        {
            Id = 31, Category = 9, Name = "Sun Terrace", Description = "sun_terrace",
            LayoutName = "sun_terrace", FileNames = "hh_room_sun_terrace", MaxVisitors = 50
        },
        new()
        {
            Id = 32, Category = 9, Name = "Peaceful Park", Description = "gate_park",
            LayoutName = "gate_park", FileNames = "hh_room_gate_park", MaxVisitors = 50
        },
        new()
        {
            Id = 33, Category = 9, Name = "Peaceful Park B", Description = "gate_park",
            LayoutName = "gate_park_2", FileNames = "hh_room_gate_park", MaxVisitors = 50, HideFromNavigator = true
        },
        new()
        {
            Id = 34, Category = 9, Name = "The Park", Description = "park",
            LayoutName = "park_a", FileNames = "hh_room_park_general,hh_room_park", MaxVisitors = 45
        },
        new()
        {
            Id = 35, Category = 9, Name = "The Infobus", Description = "park",
            LayoutName = "park_b", FileNames = "hh_room_park_general,hh_room_park", MaxVisitors = 20, HideFromNavigator = true
        },
        new()
        {
            Id = 36, Category = 10, Name = "Habbo Lido", Description = "habbo_lido",
            LayoutName = "pool_a", FileNames = "hh_room_pool,hh_people_pool", MaxVisitors = 60
        },
        new()
        {
            Id = 37, Category = 10, Name = "Lido B", Description = "habbo_lido_ii",
            LayoutName = "pool_b", FileNames = "hh_room_pool,hh_people_pool", MaxVisitors = 60, HideFromNavigator = true
        },
        new()
        {
            Id = 38, Category = 10, Name = "Rooftop Rumble", Description = "rooftop_rumble",
            LayoutName = "md_a", FileNames = "hh_room_terrace,hh_paalu,hh_people_pool,hh_people_paalu", MaxVisitors = 50
        },
        new()
        {
            Id = 39, Category = 11, Name = "Main Lobby", Description = "main_lobby",
            LayoutName = "lobby_a", FileNames = "hh_room_lobby", MaxVisitors = 100
        },
        new()
        {
            Id = 40, Category = 11, Name = "Basement Lobby", Description = "basement_lobby",
            LayoutName = "floorlobby_a", FileNames = "hh_room_floorlobbies", MaxVisitors = 50
        },
        new()
        {
            Id = 41, Category = 11, Name = "Median Lobby", Description = "median_lobby",
            LayoutName = "floorlobby_b", FileNames = "hh_room_floorlobbies", MaxVisitors = 50
        },
        new()
        {
            Id = 42, Category = 11, Name = "Skylight Lobby", Description = "skylight_lobby",
            LayoutName = "floorlobby_c", FileNames = "hh_room_floorlobbies", MaxVisitors = 50
        },
        new()
        {
            Id = 43, Category = 6, Name = "Ice Cafe", Description = "ice_cafe",
            LayoutName = "ice_cafe", FileNames = "hh_room_icecafe", MaxVisitors = 25
        },
        new()
        {
            Id = 44, Category = 6, Name = "Net Cafe", Description = "netcafe",
            LayoutName = "netcafe", FileNames = "hh_room_netcafe", MaxVisitors = 25
        },
        new()
        {
            Id = 45, Category = 5, Name = "Beauty Salon", Description = "beauty_salon_loreal",
            LayoutName = "beauty_salon0", FileNames = "hh_room_beauty_salon_general", MaxVisitors = 25
        },
        new()
        {
            Id = 46, Category = 5, Name = "The Den", Description = "the_den",
            LayoutName = "cr_staff", FileNames = "hh_room_den", MaxVisitors = 100
        },
        new()
        {
            Id = 47, Category = 12, Name = "Lower Hallways", Description = "hallway",
            LayoutName = "hallway2", FileNames = "hh_room_hallway", MaxVisitors = 25, ShowName = true
        },
        new()
        {
            Id = 48, Category = 12, Name = "Lower Hallways I", Description = "hallway",
            LayoutName = "hallway0", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 49, Category = 12, Name = "Lower Hallways II", Description = "hallway",
            LayoutName = "hallway1", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 50, Category = 12, Name = "Lower Hallways III", Description = "hallway",
            LayoutName = "hallway3", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 51, Category = 12, Name = "Lower Hallways IV", Description = "hallway",
            LayoutName = "hallway5", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 52, Category = 12, Name = "Lower Hallways V", Description = "hallway",
            LayoutName = "hallway4", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 53, Category = 12, Name = "Upper Hallways", Description = "hallway_ii",
            LayoutName = "hallway9", FileNames = "hh_room_hallway", MaxVisitors = 25, ShowName = true
        },
        new()
        {
            Id = 54, Category = 12, Name = "Upper Hallways I", Description = "hallway_ii",
            LayoutName = "hallway8", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 55, Category = 12, Name = "Upper Hallways II", Description = "hallway_ii",
            LayoutName = "hallway7", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 56, Category = 12, Name = "Upper Hallways III", Description = "hallway_ii",
            LayoutName = "hallway6", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 57, Category = 12, Name = "Upper Hallways IV", Description = "hallway_ii",
            LayoutName = "hallway10", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 58, Category = 12, Name = "Upper Hallways V", Description = "hallway_ii",
            LayoutName = "hallway11", FileNames = "hh_room_hallway", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 59, Category = 7, Name = "Star Lounge", Description = "star_lounge",
            LayoutName = "star_lounge", FileNames = "hh_room_starlounge", MaxVisitors = 35, ShowName = true
        },
        new()
        {
            Id = 60, Category = 8, Name = "Club Orient", Description = "orient",
            LayoutName = "orient", FileNames = "hh_room_orient", MaxVisitors = 35, ShowName = true
        },
        new()
        {
            Id = 61, Category = 13, Name = "Cunning Fox Gamehall", Description = "cunning_fox_gamehall",
            LayoutName = "entryhall", FileNames = "hh_room_gamehall,hh_games", MaxVisitors = 25, ShowName = true
        },
        new()
        {
            Id = 62, Category = 13, Name = "TicTacToe hall", Description = "cunning_fox_gamehall/1",
            LayoutName = "hallA", FileNames = "hh_room_gamehall,hh_games", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 63, Category = 13, Name = "Battleships hall", Description = "cunning_fox_gamehall/2",
            LayoutName = "hallB", FileNames = "hh_room_gamehall,hh_games", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 64, Category = 13, Name = "Chess hall", Description = "cunning_fox_gamehall/3",
            LayoutName = "hallC", FileNames = "hh_room_gamehall,hh_games", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 65, Category = 13, Name = "Poker hall", Description = "cunning_fox_gamehall/4",
            LayoutName = "hallD", FileNames = "hh_room_gamehall,hh_games", MaxVisitors = 25, HideFromNavigator = true, ShowName = true
        },
        new()
        {
            Id = 66, Category = 13, Name = "Battleball Lobby", Description = "bb_lobby_beginner_0",
            LayoutName = "bb_lobby_1", FileNames = "hh_game_bb,hh_game_bb_room,hh_game_bb_ui,hh_gamesys", MaxVisitors = 25, ShowName = true
        },
        new()
        {
            Id = 67, Category = 13, Name = "Snowstorm Lobby", Description = "sw_lobby_beginner_0",
            LayoutName = "snowwar_lobby_1", FileNames = "hh_gamesys,hh_game_snowwar,hh_game_snowwar_room,hh_game_snowwar_ui", MaxVisitors = 25, ShowName = true
        },
        new()
        {
            Id = 68, Category = 5, Name = "Imperial Palace", Description = "emperors",
            LayoutName = "emperors", FileNames = "hh_room_emperors", MaxVisitors = 30
        },
        new()
        {
            Id = 69, Category = 5, Name = "Beauty Salon II", Description = "beauty_salon_loreal",
            LayoutName = "beauty_salon1", FileNames = "hh_room_beauty_salon_general", MaxVisitors = 25, HideFromNavigator = true
        },
    };
}