﻿using Snouthill.Db.Models;

namespace Snouthill.Db.StaticData;

public class RoomLayoutModels
{
    public static readonly IEnumerable<RoomLayoutModel> Models = new List<RoomLayoutModel>
    {
        new()
        {
            Id = "model_a", Name = "model_a", DoorX = 3, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxx00000000|xxxxxxxxxxxx|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_b", Name = "model_b", DoorX = 0, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxxx0000000|xxxxx0000000|xxxxx0000000|xxxxx0000000|x00000000000|x00000000000|x00000000000|x00000000000|x00000000000|x00000000000|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_c", Name = "model_c", DoorX = 4, DoorY = 7, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_d", Name = "model_d", DoorX = 4, DoorY = 7, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxx000000x|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_e", Name = "model_e", DoorX = 1, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xx0000000000|xx0000000000|xx0000000000|xx0000000000|xx0000000000|xx0000000000|xx0000000000|xx0000000000|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_f", Name = "model_f", DoorX = 2, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxxxxx0000x|xxxxxxx0000x|xxx00000000x|xxx00000000x|xxx00000000x|xxx00000000x|x0000000000x|x0000000000x|x0000000000x|x0000000000x|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_g", Name = "model_g", DoorX = 1, DoorY = 7, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxx|xxxxxxxxxxxxx|xxxxxxx00000x|xxxxxxx00000x|xxxxxxx00000x|xx1111000000x|xx1111000000x|xx1111000000x|xx1111000000x|xx1111000000x|xxxxxxx00000x|xxxxxxx00000x|xxxxxxx00000x|xxxxxxxxxxxxx|xxxxxxxxxxxxx|xxxxxxxxxxxxx|xxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_h", Name = "model_h", DoorX = 4, DoorY = 4, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxx111111x|xxxxx111111x|xxxxx111111x|xxxxx111111x|xxxxx111111x|xxxxx000000x|xxxxx000000x|xxx00000000x|xxx00000000x|xxx00000000x|xxx00000000x|xxxxxxxxxxxx|xxxxxxxxxxxx|xxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_i", Name = "model_i", DoorX = 0, DoorY = 10, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxx|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|x0000000000000000|xxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_j", Name = "model_j", DoorX = 0, DoorY = 10, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxx0000000000|xxxxxxxxxxx0000000000|xxxxxxxxxxx0000000000|xxxxxxxxxxx0000000000|xxxxxxxxxxx0000000000|xxxxxxxxxxx0000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x0000000000xxxxxxxxxx|x0000000000xxxxxxxxxx|x0000000000xxxxxxxxxx|x0000000000xxxxxxxxxx|x0000000000xxxxxxxxxx|x0000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_k", Name = "model_k", DoorX = 0, DoorY = 13, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx00000000|xxxxxxxxxxxxxxxxx00000000|xxxxxxxxxxxxxxxxx00000000|xxxxxxxxxxxxxxxxx00000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|x000000000000000000000000|x000000000000000000000000|x000000000000000000000000|x000000000000000000000000|x000000000000000000000000|x000000000000000000000000|x000000000000000000000000|x000000000000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_l", Name = "model_l", DoorX = 0, DoorY = 16, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxx|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|x00000000xxxx00000000|xxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_m", Name = "model_m", DoorX = 0, DoorY = 15, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|x0000000000000000000000000000|x0000000000000000000000000000|x0000000000000000000000000000|x0000000000000000000000000000|x0000000000000000000000000000|x0000000000000000000000000000|x0000000000000000000000000000|x0000000000000000000000000000|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxx00000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_n", Name = "model_n", DoorX = 0, DoorY = 16, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxx|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x000000xxxxxxxx000000|x000000x000000x000000|x000000x000000x000000|x000000x000000x000000|x000000x000000x000000|x000000x000000x000000|x000000x000000x000000|x000000xxxxxxxx000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|x00000000000000000000|xxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_o", Name = "model_o", DoorX = 0, DoorY = 18, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxx00000000xxxx|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|x111111100000000000000000|x111111100000000000000000|x111111100000000000000000|x111111100000000000000000|x111111100000000000000000|x111111100000000000000000|x111111100000000000000000|x111111100000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxx0000000000000000|xxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_p", Name = "model_p", DoorX = 0, DoorY = 23, DoorZ = 2, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxx|xxxxxxx222222222222|xxxxxxx222222222222|xxxxxxx222222222222|xxxxxxx222222222222|xxxxxxx222222222222|xxxxxxx222222222222|xxxxxxx22222222xxxx|xxxxxxx11111111xxxx|x222221111111111111|x222221111111111111|x222221111111111111|x222221111111111111|x222221111111111111|x222221111111111111|x222221111111111111|x222221111111111111|x2222xx11111111xxxx|x2222xx00000000xxxx|x2222xx000000000000|x2222xx000000000000|x2222xx000000000000|x2222xx000000000000|x2222xx000000000000|x2222xx000000000000|xxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_q", Name = "model_q", DoorX = 10, DoorY = 4, DoorZ = 2, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxx|xxxxxxxxxxx22222222|xxxxxxxxxxx22222222|xxxxxxxxxxx22222222|xxxxxxxxxxx22222222|xxxxxxxxxxx22222222|xxxxxxxxxxx22222222|x222222222222222222|x222222222222222222|x222222222222222222|x222222222222222222|x222222222222222222|x222222222222222222|x2222xxxxxxxxxxxxxx|x2222xxxxxxxxxxxxxx|x2222211111xx000000|x222221111110000000|x222221111110000000|x2222211111xx000000|xx22xxx1111xxxxxxxx|xx11xxx1111xxxxxxxx|x1111xx1111xx000000|x1111xx111110000000|x1111xx111110000000|x1111xx1111xx000000|xxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "model_r", Name = "model_r", DoorX = 10, DoorY = 4, DoorZ = 3, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxx33333333333333|xxxxxxxxxxx33333333333333|xxxxxxxxxxx33333333333333|xxxxxxxxxxx33333333333333|xxxxxxxxxxx33333333333333|xxxxxxxxxxx33333333333333|xxxxxxx333333333333333333|xxxxxxx333333333333333333|xxxxxxx333333333333333333|xxxxxxx333333333333333333|xxxxxxx333333333333333333|xxxxxxx333333333333333333|x4444433333xxxxxxxxxxxxxx|x4444433333xxxxxxxxxxxxxx|x44444333333222xx000000xx|x44444333333222xx000000xx|xxx44xxxxxxxx22xx000000xx|xxx33xxxxxxxx11xx000000xx|xxx33322222211110000000xx|xxx33322222211110000000xx|xxxxxxxxxxxxxxxxx000000xx|xxxxxxxxxxxxxxxxx000000xx|xxxxxxxxxxxxxxxxx000000xx|xxxxxxxxxxxxxxxxx000000xx|xxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "newbie_lobby", Name = "newbie_lobby", DoorX = 2, DoorY = 11, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxx000000|xxxxx0xxxxxxxxxx000000|xxxxx00000000xxx000000|xxxxx000000000xx000000|0000000000000000000000|0000000000000000000000|0000000000000000000000|0000000000000000000000|0000000000000000000000|xxxxx000000000000000xx|xxxxx000000000000000xx|x0000000000000000000xx|x0000000000000000xxxxx|xxxxxx00000000000xxxxx|xxxxxxx0000000000xxxxx|xxxxxxxx000000000xxxxx|xxxxxxxx000000000xxxxx|xxxxxxxx000000000xxxxx|xxxxxxxx000000000xxxxx|xxxxxxxx000000000xxxxx|xxxxxxxx000000000xxxxx|xxxxxx00000000000xxxxx|xxxxxx00000000000xxxxx|xxxxxx00000000000xxxxx|xxxxxx00000000000xxxxx|xxxxxx00000000000xxxxx|xxxxx000000000000xxxxx|xxxxx000000000000xxxxx"
        },
        new()
        {
            Id = "theater", Name = "theater", DoorX = 20, DoorY = 27, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXX|XXXXXXX111111111XXXXXXX|XXXXXXX11111111100000XX|XXXX00X11111111100000XX|XXXX00x11111111100000XX|4XXX00X11111111100000XX|4440000XXXXXXXXX00000XX|444000000000000000000XX|4XX000000000000000000XX|4XX0000000000000000000X|44400000000000000000000|44400000000000000000000|44X0000000000000000O000|44X11111111111111111000|44X11111111111111111000|33X11111111111111111000|22X11111111111111111000|22X11111111111111111000|22X11111111111111111000|22X11111111111111111000|22X11111111111111111000|22211111111111111111000|22211111111111111111000|XXXXXXXXXXXXXXXXXXXX00X|XXXXXXXXXXXXXXXXXXXX00X"
        },
        new()
        {
            Id = "library", Name = "library", DoorX = 20, DoorY = 3, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxx11111xx1xx1x111111x|xxxxxxxxxxxx111111xx1xx11111111x|xx111xxxxxxx111111xx1xx11111111x|xx111xxxxxxx1111111111111111111x|xx111xxxxxxx1111111111111111111x|xx111xxxxxxx1111111111111111111x|xx111xxxxxxx1111111111111xxxxxxx|xx111xxxxxx11111111111111111111x|xx111xxxxxx11111111111111111111x|xx111xxxxxx11111111111111111111x|xx111xxxxxx11111111111111xxxxxxx|xx111xxxxxxxx111111111111111111x|xx111xx11111x111111111111111111x|xx111xx11111x111111111111111111x|xx111xxxxx11x11111111x111xxxxxxx|xx111xxxxxxxx11111111xx11111111x|xx111xxx1111111111111xxx1111111x|xx111xxx1111111111111xxxx111111x|xxx111xx1111111111x11xxxx000000x|xxxxx1111xx1111111x11xxxx000000x|xxxxxxxxxxxx111111x11xxxx000000x|xxxxxxxxxxxx11xx11x11xxxx000000x|xxxxxxxxxxxx11xx11x11xxxx000000x|xxxxxxxxxxxx11xx11x11xxxx000000x|xxxxxxxxxxxx11xx11x11xxxx000000x|xxxxxxxxxxxx11xx11x11xxxx000000x|xxxxxxxxxxxx11xx11x111xxx000000x|xxxxxxxxxxxxxxxxxxxx11xxx000000x|xxxxxxxxxxxxxxxxxxxx11xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxx22222xxxxxxx|xxxxxxxxxxxxxxxxxxxx22222xxxxxxx|xxxxxxxxxxxxxxxxxxxx22222xxxxxxx|xxxxxxxxxxxxxxxxxxxx22222xxxxxxx|xxxxxxxxxxxxxxxxxxxx22222xxxxxxx|xxxxxxxxxxxxxxxxxxxx22222xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "floatinggarden", Name = "floatinggarden", DoorX = 2, DoorY = 21, DoorZ = 5, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxxxx333333xxxxxxxxx|xxxxxxxxxxxxxxxx3xxxx3xxxxxxxxx|xxxxxxxxxxxxxxxx3xxxx3xxxxxxxxx|xxxxxxxxxxxxxxxx3xxxx3xxxxxxxxx|xxxxxxxxxxxxxxx223xxx33xxxxxxxx|xxxxxxxxxxxxxxx11xxx33333xxxxxx|xxxxxxxxxxxxxxxx11xx3333333xxxx|xxxxxxxxxxxxxxxx11xx33333333xxx|xxxxxxxxxxxxxxxxx11xxxxxxxx3xxx|xxxxxxxxxxxxxxxxxx11xxxx3333xxx|xxxxxxxxxxxxxxxxxxx1xxxx33333xx|xxxxxxxxxxxxxxxxxxx1xxx3333333x|555xxxxxxxxxxx1111111x333333333|555xxxxxxxxxxx21111111xxxxxx333|555xxxxxxxxxxx22111111111xxxxxx|555xxxxxxxxxxx222xxxxxxx111xxxx|555xxxxxxxxxxx22xxxxxxxxxx1xxxx|555xxxxxxxxxxx23333333333x111xx|555xxxxxxxx33333333333333x111xx|555xxxxxxxx333333x3333333x111xx|555xxxxxxxx33333333333333x111xx|555xxxxxxxx33x33333333333x111xx|555xxxxxxxx33x33x33333333x111xx|555xxxxxxxx33x33x33333333x111xx|5554333333333x333x3333333x111xx|x554333333xxxx33xxxxxxxxxx111xx|xxxxxxxxx3xxxx333221111111111xx|xxxxxxxxx3xxxx333221111111111xx|xxxxxxxxx33333333xx1111x11x11xx|xxxxxxxxx33333333111xxx11xxxxxx|xxxxxxxxxxxxxx33311xxxx11xxxxxx|xxxxxxxxxxxxxx33311xxxx11xxxxxx|xxxxxxxxxxxxxx333x1xxxx11xxxxxx|xxxxxxxxxxxxxx333x1xx111111xxxx|xxxxxxxxxxxxxx33311xx111111xxxx|xxxxxxxxxx333333311xx111111xxxx|xxxxxxxxxxx33333311xx111111xxxx|xxxxxxxxxxxxxxxx111xxxxxxxxxxxx|xxxxxxxxxxxxxxx111xxxxxxxxxxxxx"
        },
        new()
        {
            Id = "sunset_cafe", Name = "sunset_cafe", DoorX = 34, DoorY = 40, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxx00000xx00000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000000xxx0000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000000xxxx000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx0000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "pool_a", Name = "pool_a", DoorX = 2, DoorY = 25, DoorZ = 7, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx7xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx777xxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx7777777xxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx777777777xxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx7xxx777777xxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx7x777777777xxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx7xxx77777777xxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx7x777777777x7xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx7xxx7777777777xxxxxxxxxxxxxx|xxxxxxxxxxxxxxx777777777777xxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx77777777777x2111xxxxxxxxxxxx|xxxxxxxxxxxxxxx7777777777x221111xxxxxxxxxxx|xxxxxxxxx7777777777777777x2211111xxxxxxxxxx|xxxxxxxxx7777777777777777x22211111xxxxxxxxx|xxxxxxxxx7777777777777777x222211111xxxxxxxx|xxxxxx77777777777777777777x222211111xxxxxxx|xxxxxx7777777xx777777777777x222211111xxxxxx|xxxxxx7777777xx77777777777772222111111xxxxx|xxxxxx777777777777777777777x22221111111xxxx|xx7777777777777777777777x322222211111111xxx|77777777777777777777777x33222222111111111xx|7777777777777777777777x333222222211111111xx|xx7777777777777777777x333322222222111111xxx|xx7777777777777777777333332222222221111xxxx|xx777xxx777777777777733333222222222211xxxxx|xx777x7x77777777777773333322222222222xxxxxx|xx777x7x7777777777777x33332222222222xxxxxxx|xxx77x7x7777777777777xx333222222222xxxxxxxx|xxxx77777777777777777xxx3222222222xxxxxxxxx|xxxxx777777777777777777xx22222222xxxxxxxxxx|xxxxxx777777777777777777x2222222xxxxxxxxxxx|xxxxxxx777777777777777777222222xxxxxxxxxxxx|xxxxxxxx7777777777777777722222xxxxxxxxxxxxx|xxxxxxxxx77777777777777772222xxxxxxxxxxxxxx|xxxxxxxxxx777777777777777222xxxxxxxxxxxxxxx|xxxxxxxxxxx77777777777777x2xxxxxxxxxxxxxxxx|xxxxxxxxxxxx77777777777777xxxxxxxxxxxxxxxxx|xxxxxxxxxxxxx777777777777xxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx7777777777xxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx777777xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx7777xxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxx77xxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "pub_a", Name = "pub_a", DoorX = 15, DoorY = 25, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxx2222211111xxx|xxxxxxxxx2222222211111xxx|xxxxxxxxx2222222211111xxx|xxxxxxxxx2222222211111xxx|xxxxxxxxx2222222222111xxx|xxxxxxxxx2222222222111xxx|xxxxxxxxx2222222222000xxx|xxxxxxxxx2222222222000xxx|xxxxxxxxx2222222222000xxx|xxxxxxxxx2222222222000xxx|x333333332222222222000xxx|x333333332222222222000xxx|x333333332222222222000xxx|x333333332222222222000xxx|x333333332222222222000xxx|x333332222222222222000xxx|x333332222222222222000xxx|x333332222222222222000xxx|x333332222222222222000xxx|x333333332222222222000xxx|xxxxx31111112222222000xxx|xxxxx31111111000000000xxx|xxxxx31111111000000000xxx|xxxxx31111111000000000xxx|xxxxx31111111000000000xxx|xxxxxxxxxxxxxxx00xxxxxxxx|xxxxxxxxxxxxxxx00xxxxxxxx|xxxxxxxxxxxxxxx00xxxxxxxx|xxxxxxxxxxxxxxx00xxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "md_a", Name = "md_a", DoorX = 3, DoorY = 4, DoorZ = 7, DoorDirection = 2,
            HeightMap =
                "xxxxxxxx77xxxxxxxxxxxxxxxx|xxxxxxxx77xxxxxxxxxxxxxxxx|xxxxxx77777x77xxxxxxxxxxxx|xxx77777777777xxx44xxxxxxx|77777777777777xx444444444x|777777777777777xx44444444x|xxx777777777777xx44444444x|xxxx7777777777xxx44444444x|7777777777777777744448444x|7777777777777x4x744448444x|777777777777x444444448444x|7777777777774444444448444x|7777777777774444444448444x|777777777777x444444448444x|7777777777777x44444448444x|xxx777777777777x444448444x|xxx7777777777777444448444x|xxx7777777777777444448444x|xxx777777777777x444448444x|xxx77777777777x4444444444x|xxxx777777777444444444444x|xxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "picnic", Name = "picnic", DoorX = 16, DoorY = 5, DoorZ = 2, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xx22222xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|22xxxxxxxxxxxxx22xxxxxxxxxxxxxxxxxxxxx|2222222222222222222x222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222xxx222222222222222222222222|2222222222xx33x22222222222222222222222|222222222xx3333x2222222222222222222222|222222222x333333x222222222222222222222|222222222x333333x222222222222222222222|2222222222x3332x2222222222222222222222|22222222222x33x22222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222x22222xxxx22222222222222222222|22222222222222xxxx22222222222222222222|22222222222222xxx222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222|22222222222222222222222222222222222222"
        },
        new()
        {
            Id = "park_a", Name = "park_a", DoorX = 2, DoorY = 15, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0xxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00xxxxxxxxxxxx|xxxxxxxxxxxxx0x00xxxxxxxxxxx0x000xxxxxxxxxxx|xxxxxxxxxxxx0000000000000000000000xxxxxxxxxx|xxxxxxxxxxx000000000000000000000000xxxxxxxxx|xxxxxxxxxxx0000000000000000000000000xxxxxxxx|xxxxxxxxxxx00000000000000000000000000xxxxxxx|xxxxxxxx000000000000000000000000000000xxxxxx|xxxxxxx00000000000000000000000000000000xxxxx|xxxxxxx000000000000000000000000000000000xxxx|xxxxxxx0000000000000000000000000000000000xxx|xxxxxxxxx000000000000000000000000000000000xx|00000000000000000000xx00000000000000000000xx|0000000000000000000xxxx00000000000xxxxxxx0xx|0000000000000000000xxxx00000000000x00000xxxx|xxxxx00x0000000000xxxxx0xxxxxx0000x0000000xx|xxxxx0000000000000xxxxx0xx000x0000x000000xxx|xxxxx0000000000000xxxxx0x000000000x00000xxxx|xxxxx000000x0000000xxxx0x000000000xxx00xxxxx|xxxxxxxx000x0000000xxx00xxx000000x0000xxxxxx|xxxxxxxx000x000000xxxx0x0000000000000xxxxxxx|xxxxxxxx000x000000011100000000000000xxxxxxxx|xxxxxxxx000x00000001110000000000000xxxxxxxxx|xxxxxxxxx00x0000000111x00000000x00xxxxxxxxxx|xxxxxxxxxx0x0000000xxx0000000xxxxxxxxxxxxxxx|xxxxxxxxxxxx000000xxxx0000000xxxxxxxxxxxxxxx|xxxxxxxxxxxx000000xxx00xxxxx00xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxx0xx000x00xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxx0x000000xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxx0x00000xxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxxxx00xxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxxxx0xxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "park_b", Name = "park_b", DoorX = 11, DoorY = 2, DoorZ = 0, DoorDirection = 6,
            HeightMap = "0000x0000000|0000xx000000|000000000000|00000000000x|000000000000|00x0000x0000"
        },
        new()
        {
            Id = "pool_b", Name = "pool_b", DoorX = 9, DoorY = 21, DoorZ = 7, DoorDirection = 1,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx7xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx777xxxxxxxxxxx|xxxxxxxxxxxxxxxxxx8888888x7xxx77777xxxxxxxxxx|xxxxxxxxxxxxxxxxxx8888888x7xxx777777xxxxxxxxx|xxxxxxxxxxxxxxxx88xxxxx77x7x777777777xxxxxxxx|xxxxxxxxxxxxxxxx88x7777777777777777777xxxxxxx|xxxxxxxxxxxxxxxx88x77777777777777777777xxxxxx|xxxxxxxxxxxxxx9988x77777777777777777777xxxxxx|xxxxxxxxxxxxxx9988x7777777777777777777x00xxxx|xxxxxxxxxxxxxx9988x777777777777777777x0000xxx|xxxxxxxxxxxxxx9988x7777777x0000000000000000xx|xxxxxxxxxxxxxx9988x777777x000000000000000000x|7777777777xxxx9988777777x0x0000000000000000xx|x7777777777xxx998877777x000x00000000000000xxx|xx7777777777xx99887777x00000x000000000000xxxx|xxx7777777777x9988777x0000000x0000000000xxxxx|xxxx777777777x777777x00000000x000000000xxxxxx|xxxxx777777777777777000000000x00000000xxxxxxx|xxxxxx77777777777777000000000x0000000xxxxxxxx|xxxxxxx777777x7777770000000000xxxx00xxxxxxxxx|xxxxxxxx77777777777xx0000000000000xxxxxxxxxxx|xxxxxxxxx777777110000x000000000000xxxxxxxxxxx|xxxxxxxxxx7x77x1100000x0000000000xxxxxxxxxxxx|xxxxxxxxxxx777x11000000x00000000xxxxxxxxxxxxx|xxxxxxxxxxxx771110000000x000000xxxxxxxxxxxxxx|xxxxxxxxxxxxx111100000000x0000xxxxxxxxxxxxxxx|xxxxxxxxxxxxxx11100000000x000xxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx1100000000x00xxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx110000000x0xxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx110000000xxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxx1100000xxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxx11000xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxx110xxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "ballroom", Name = "ballroom", DoorX = 13, DoorY = 6, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xxxx4444444444444444444|xxxx4444444444444444444|xxxx4444444444444444444|xxxx33x2222444442222x33|xxxx2222222x00xx2222222|xxxx22222220000x2222222|xxxx11x0000x000x0000x11|xxxx0000000000000000000|11100000000000000000000|11100000000000000000000|11100000000000000000000|xxxx0000000000000000000|22210000000000000000000|22210000000000000000000|22210000000000000000000|xxxx0000000000000000000|11100000000000000000000|11100000000000000000000|11100000000000000000000|xxxxx000x11111111x0000x|xxxxxx00x1111x111x000xx|xxxxxxx0x11111111x00xxx|xxxxxxxxx11111111x0xxxx|xxxxxxxxx11111111xxxxxx"
        },
        new()
        {
            Id = "cafe_gold0", Name = "cafe_gold0", DoorX = 9, DoorY = 29, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxx1111xxxxxxx|xxxxxxxxxx11111xxxxxx|xxxxxxxxxx111111xxxxx|xx111111111111111xxxx|x11111111111111111xxx|1111111111111111111xx|11111111111111111111x|111111111111111111111|111111111111111111111|1111111111111x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000x1111111|1111111000000xxx00000|111111100000000000000|111111100000000000000|111111100000000000000|111111100000000xxxxx0|11111110000000xxxxxx0|11111110000000xxxxxx0|11111110000000xxxxxxx|x1111110000000xxxxxxx|xxxxxxxx0000000000xxx|xxxxxxxx000xxxxxxxxxx|xxxxxxxx000xxxxxxxxxx|xxxxxxxx000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "cafe", Name = "cafe", DoorX = 30, DoorY = 40, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxx00000xx00000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000000xxx0000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000000xxxx000000xxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxx0000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "den", Name = "den", DoorX = 3, DoorY = 22, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "00000000xxxxxxxx|0000000000000000|0000000000000000|000000000000xx00|0000000000000000|0000000000000000|0000000000000000|x000000000000000|0000000000000000|0000000000000000|0000000000000000|0000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|xxx00xxxxxxxxxxx|xxx00xxxxxxxxxxx|xxx00xxxxxxxxxxx"
        },
        new()
        {
            Id = "gardens", Name = "gardens", DoorX = 2, DoorY = 15, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0xxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00xxxxxxxxxxxx|xxxxxxxxxxxxx0x00xxxxxxxxxxx0x000xxxxxxxxxxx|xxxxxxxxxxxx0000000000000000000000xxxxxxxxxx|xxxxxxxxxxx000000000000000000000000xxxxxxxxx|xxxxxxxxxxx0000000000000000000000000xxxxxxxx|xxxxxxxxxxx00000000000000000000000000xxxxxxx|xxxxxxxx000000000000000000000000000000xxxxxx|xxxxxxx00000000000000000000000000000000xxxxx|xxxxxxx000000000000000000000000000000000xxxx|xxxxxxx0000000000000000000000000000000000xxx|xxxxxxxxx000000000000000000000000000000000xx|00000000000000000000xx00000000000000000000xx|0000000000000000000xxxx00000000000xxxxxxx0xx|0000000000000000000xxxx00000000000x00000xxxx|xxxxx00x0000000000xxxxx0xxxxxx0000x0000000xx|xxxxx0000000000000xxxxx0xx000x0000x000000xxx|xxxxx0000000000000xxxxx0x000000000x00000xxxx|xxxxx000000x0000000xxxx0x000000000xxx00xxxxx|xxxxxxxx000x0000000xxx00xxx000000x0000xxxxxx|xxxxxxxx000x000000xxxx0x0000000000000xxxxxxx|xxxxxxxx000x000000011100000000000000xxxxxxxx|xxxxxxxx000x00000001110000000000000xxxxxxxxx|xxxxxxxxx00x0000000111x00000000x00xxxxxxxxxx|xxxxxxxxxx0x0000000xxx0000000xxxxxxxxxxxxxxx|xxxxxxxxxxxx000000xxxx0000000xxxxxxxxxxxxxxx|xxxxxxxxxxxx000000xxx00xxxxx00xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxx0xx000x00xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxx0x000000xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxx0x00000xxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxxxx00xxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxx0xxxxx0xxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "gate_park", Name = "gate_park", DoorX = 17, DoorY = 26, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxx222xx222222xxx22xxxxxxx|xxxxxxxxx222xx2222222xx22xxxxxxx|xxxxxxxxx22222222222222222xxxxxx|xxxxxxxxx22222222222222222xxxxxx|xxxxxxxxx22222222222222222xxxxxx|xxxxxxxxx22222x22222x22222xxxxxx|xxxxxxxxx11111x22222x11111xxxxxx|0000000xx00000x22222x00000xxxxxx|0000000xx00000000000000000xxxxxx|000000000000000000000000000xx00x|000000000000xxx00000xxx00000000x|000000000000xxx00000xxx00000000x|000000000000xxx00000xxx000000000|00000000000000000000000000000000|x0000000000000000000000000000000|xxx00000000000000000000000000000|xxxxx000000000000000000000000000|xxxxx000000000000000000000000000|xxxxx000000000000000000000000xxx|xxxxxx00000000000000000000000xxx|xxxxxxx000000000000000000000xxxx|xxxxxxxxxx00000000000000000xxxxx|xxxxxxxxxx0000000000000000xxxxxx|xxxxxxxxxx000000000000000xxxxxxx|xxxxxxxxxxxxx00000000000xxxxxxxx|xxxxxxxxxxxxxx000000000xxxxxxxxx|xxxxxxxxxxxxxxxx000xxxxxxxxxxxxx|xxxxxxxxxxxxxxxx000xxxxxxxxxxxxx|xxxxxxxxxxxxxxxx000xxxxxxxxxxxxx"
        },
        new()
        {
            Id = "gate_park_2", Name = "gate_park_2", DoorX = 17, DoorY = 23, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxx111111111111xxxxxxxxxxxx|xxxxxxxxxx11111111111111xxxxxxxxxxx|xxxxxxxxxx11111111111111xxxxxxxxxxx|xxxxxxxxxx11xxxx11xxxx11xxxxxxxxxxx|xxxxxxxxxx00xxxx00xxxx00xxxxxxxxxxx|xxxxxxx0000000000000000000xxxxxxxxx|xxxxxx000000000000000000000xxxxxxxx|xxxxx0000000000000000000x000xxxxxxx|xxxx00000000000000000000xx000xxxxxx|xxxx00000000000000000000xxx000xxxxx|xxxx00000000000000000000xxxx00xxxxx|000000000000000000000000000000xxxxx|0000000000000000000000000000000xxxx|000000000000000000000000000000xxxxx|000000000000000000000000000000xxxxx|000000000000000000000000000000xxxxx|xx00000000000000000000000000000000x|xxx000xxxx00000000000000xxxx0000000|xxx0000xxx00000000000000xxx00000000|xxxx0000xx00000000000000xx000000000|xxxxx0000x00000000000000x00000000xx|xxxxxx00000000000000000000000xxxxxx|xxxxxxx00000x000000000000000x0xxxxx|xxxxxxxx0000xxx0000xxx000000xxxxxxx|xxxxxxxxx000xxx0000xxx000000xxxxxxx|xxxxxxxxxxxxxxx0000xxx000000xxxxxxx|xxxxxxxxxxxxxxxx000xxx000000xxxxxxx|xxxxxxxxxxxxxxxxxxxxxx00000xxxxxxxx"
        },
        new()
        {
            Id = "sun_terrace", Name = "sun_terrace", DoorX = 9, DoorY = 17, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxx21000000000xxxxxxxx|xxxxxx3xxx000xx000xxxxxxx|xxxxxx4xxx000xxx000xxxxxx|xxxxxx44xx000x00x000xxxxx|xxxxxx44xx0000xx00000xxxx|xxxxxx44xx000000000000xxx|xxxxxx44xx0000000000000xx|xxxxxxx4xxxxxxx00000000xx|xxxxxxx4xxxxxxx0000000xxx|xxxxxx444432222xxx00xxxxx|xxxxxx444432222x0000000xx|xxxxxx444432222x0000000xx|xxxxxx44400x222x0000000xx|xxxxxx444000x11x0000000xx|xxxxxx444000000x0000000xx|xxxxxx444000000x0000000xx|xxxxxx440000000000000000x|xxxxxx4400000000000000000|x8876x444000000x000000000|x8xx6x444000000x000000000|x9xx6x444000000x000000000|999x65444000000x000000000|999xxx444xxxxxxxxxx000000|999xxx444xxxxxxxxxxx00000|999xxx333xxxxxxxxxxxx0000|999xxx222222222222222x000|xxxxxx222222222222222xx00|xxxxxx222222222222222xxx0|xxxxxx222222222222222xxxx|xxxxxxx22222222222222xxxx|xxxxxxxx2222222222222xxxx"
        },
        new()
        {
            Id = "space_cafe", Name = "space_cafe", DoorX = 21, DoorY = 17, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "x3333x333211111xxxxxxxxx|x3333x333211111xx3333333|xxxxxx333211111xx3333333|33333333xx11111xx3333333|33333333xx11111xx3333333|33x333xxxx11111xx3333333|xxx222xxx111111xx3333333|22222222xx11111xx3333333|22222222xxx1111xx3333333|22222222xxxx1111x2222222|22222222xxxx1111x1111111|22222222xxxx111111111111|22222222xxxx111111111111|xxx222xxxxx1111111111111|xxxx33xxxx11111111111111|xxx333321111111111111111|xxx333321111111111111111|xxx333321111111111111111|xxxxxxxxxxxxx1111xxxx11x|xxxxxxxxxxxxx0000xxxx11x|xxxxxxxxxx0000000xxxx11x|xxxxxxxxxx0000000xxxxxxx|xxxxxxxxxx0000000xxxxxxx|xxxxxxxxxx0000000xxxxxxx|xxxxxxxxxx0000000xxxxxxx|xxxxxxxxxx0000000xxxxxxx"
        },
        new()
        {
            Id = "beauty_salon0", Name = "beauty_salon0", DoorX = 4, DoorY = 3, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxx0000000000000xxxxxxxx|xxx00000000000000xxxxxxx|xxxxxx000000000000xxxxxx|xxxxxxxxxxxxx0000xxxxxxx|xxxx0x0000x00000000xxxxx|xxx00xxxxxx0000000xxxxxx|xx000x000xx0000000xxxxxx|xx000xxxxx00000000xxxxxx|xx000x000000000000xxxxxx|xx000x000000000000xxxxxx|xx00xx000000000000xxxxxx|xx00xx00x0000000000xxxxx|xx00xx00x0000000000xxxxx|xx00xx0000000000000xxxxx|xx00xx0000000000000xxxxx|xx000x0xx0000000000xxxxx|xx000x0x00000000000xxxxx|xx000x0x00x00000000xxxxx|xx000x0x00000000000xxxxx|xx000x0x00x00000000xxxxx|xx000xx000000000000xxxxx|xx00000000000000000000xx|xx00000000000000000000xx|xxxxxx0000000000000000xx"
        },
        new()
        {
            Id = "chill", Name = "chill", DoorX = 22, DoorY = 22, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxx00xxxxxxxx|xxxxxxxxxxx000000xxxxxxxx|xxxxxxxxxxx000000xxxxxxxx|xxxxxxxxxxxxxx000xxxxxxxx|xxxxxxxxxxxxxxxx0xxxxxxxx|xxxxxxxxx00000000xxxxxxxx|xxxxxxxx000000xxxxxxxxxxx|xxxxxxxx000000xxxxxxxxxxx|xxxxxxxx000000xxxxxxxxxxx|xxxxxxxx000000xxxxxxxxxxx|xxxxxxxx000000xxxxxxxxxxx|xxxxxxxx0000000xxxxxxxxxx|xxxxxxxx00000000xxxxxxxxx|xxxxxxxx0000000000xxxxxxx|xxxxxxxx0000000000xxxxxxx|xxxxxxxx0000000000xxxxxxx|xxxxxxxx0000000000xxxxxxx|xx000000000000xxxxxxxxxxx|xx000000000000000000000xx|xx000000000000000000000xx|xx000000000xx0000000000xx|xx000000000xxxxx000000000|xx000000000xxx0x000000000|xx00000x000xxx0x000000000|xx000000000xxxxx0000000xx|xx000000000000000000000xx|xx000000000000000000000xx|xx000000000000000000000xx|xx000000000000xxxxxxxxxxx"
        },
        new()
        {
            Id = "dusty_lounge", Name = "dusty_lounge", DoorX = 14, DoorY = 1, DoorZ = 2, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx22xxxxxxxxxxxxx|xxxxxxxxxx222x222x2xxxxxxxxxx|xxxxxxx33322222222223xxxxxxx3|xxxxxxx33322222222223xxxxxxx3|xxxxxxx33322222222223x33333x3|xxxxxxx33322222222223x33333x3|xx111xx33322222222223xxxxxxx3|xx111xxx332222222222333333333|xx111xxxx32222222222333333333|xx111xxxxxx222222222333333333|xx111xxxxxxx1111111x333333333|xx111xxxxxxx1111111x222222222|xx111xxxxxx111111111111111111|xx111xxxxxx111111111111111111|11111xxxxxx111111111111111111|11111xxxxxx111111111111111111|11x11xxxxxx111111111111111111|11xxxxxxxxx11111111111111111x|x11xxxxxxxxx1111111x1111111xx|xx11xxxxxxx111111111111111xxx|xxx11xxxxxx11111111111111xxxx|xxxx11111111111111111111xxxxx|xxxxx11111111111111xxxxxxxxxx|xxxxxxxxxxx11111111xxxxxxxxxx|xxxxxxxxxxx11111111xxxxxxxxxx"
        },
        new()
        {
            Id = "cr_staff", Name = "cr_staff", DoorX = 3, DoorY = 22, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "00000000xxxxxxxx|0000000000000000|0000000000000000|000000000000xx00|0000000000000000|0000000000000000|0000000000000000|x000000000000000|0000000000000000|0000000000000000|0000000000000000|0000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|x000000000000000|xxx00xxxxxxxxxxx|xxx00xxxxxxxxxxx|xxx00xxxxxxxxxxx"
        },
        new()
        {
            Id = "rooftop", Name = "rooftop", DoorX = 17, DoorY = 12, DoorZ = 4, DoorDirection = 0,
            HeightMap =
                "44xxxxxxxxxxxxxxxxxx|444xxxxxxxxxxx444444|4444xxxxxxxxxx444444|44444xxxx4xxxx444444|444444xxx44xxx444444|44444444444444444444|44444444444444444444|44444444444444444444|44444444xx44xx44xx44|44444444xx44xx44xx44|44444444444444444444|44444444444444444444|44444444444444444444|x444444x444444xx4444|x444444x444444xx333x|x444444x444444xx222x|x444444x444444xx11xx|x444444x444444xxxxxx"
        },
        new()
        {
            Id = "rooftop_2", Name = "rooftop_2", DoorX = 4, DoorY = 11, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "x0000x000|xxxxxx000|000000000|000000000|000000000|000000000|000000000|000000000|000000000|000000000|xxx000xxx|xxx000xxx"
        },
        new()
        {
            Id = "tearoom", Name = "tearoom", DoorX = 21, DoorY = 19, DoorZ = 1, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxx|xxxxxxxx3333x33333333x|333333xx3333x33333333x|3333333x3333x33333333x|3333333x3333x33333333x|3333333xxxxxx33333333x|333333333333333333333x|333333333333333333333x|333333333333333333333x|333333333333333333333x|33333333222x333333333x|33333333222x333333333x|33333333222x333333333x|33333333222x333333333x|33333333111x333333333x|33333333111x333333333x|33333333111x333333333x|xxxxxxxx111xxxxxxxxxxx|11111111111111111111xx|1111111111111111111111|1111111111111111111111|11111111111111111111xx"
        },
        new()
        {
            Id = "cafe_ole", Name = "taivas_cafe", DoorX = 14, DoorY = 29, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXX111111X|XXXXXXXXXXXXX1111111|XXXXXXXXXXXXX1111111|XXXXXXXXXXXXX1111111|XXXXXXXXXXXXX1111111|XXX11111111111111111|XXX11111111111111111|XX111111111111111111|XX111111111111111111|XX111111111111111111|XXX11111111111111111|111111111XXXXXXX1111|111111111X0000000000|111111111X0000000000|111111111X0000000000|111111111X0000000000|111111111X0000000000|111111111X0000000000|111111111X0000000000|111111111X0000000000|111111111X0000000000|X11111111X0000000000|XX1111111X0000000000|XXX111111X0000000000|XXXX11111X0000000000|XXXXX111110000000000|XXXXXX11110000000000|XXXXXXX1110000000000|XXXXXXXX11000000000X|XXXXXXXXXX00000000XX|XXXXXXXXXXXXXX00XXXX|XXXXXXXXXXXXXX00XXXX"
        },
        new()
        {
            Id = "cr_cafe", Name = "cr_cafe", DoorX = 20, DoorY = 10, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "0000000000000000000xx|x000000000000000000xx|xx00000000000000000xx|xx00000000000000000xx|xx00000000000000000xx|xxxx000000000000000xx|0000000000000000000xx|0000000000000000000xx|x000000000000000000xx|xx00000000000000000xx|xxxx00000000000000000|xxx000000000000000000|xxx0000000000000000xx|xxx0000000000000000xx|xx00000000000000000xx|xx00000000000000000xx|xx00000000000000000xx|xx00000000000000000xx|xx00000000000000000xx|xx00000000000000000xx"
        },
        new()
        {
            Id = "lobby_a", Name = "lobby_a", DoorX = 12, DoorY = 27, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXX77777777777XXXXX|XXXXXXXXX777777777777XXXX|XXXXXXXXX777777777766XXXX|XXXXXXXXX777777777755XXXX|XX333333333333333334433XX|XX333333333333333333333XX|XX333333333333333333333XX|33333333333333333333333XX|333333XXXXXXX3333333333XX|333333XXXXXXX2222222222XX|333333XXXXXXX2222222222XX|XX3333XXXXXXX2222222222XX|XX3333XXXXXXX222222221111|XX3333XXXXXXX111111111111|333333XXXXXXX111111111111|3333333222211111111111111|3333333222211111111111111|3333333222211111111111111|XX33333222211111111111111|XX33333222211111111111111|XX3333322221111111XXXXXXX|XXXXXXX22221111111XXXXXXX|XXXXXXX22221111111XXXXXXX|XXXXXXX22221111111XXXXXXX|XXXXXXX22221111111XXXXXXX|XXXXXXX222X1111111XXXXXXX|XXXXXXX222X1111111XXXXXXX|XXXXXXXXXXXX11XXXXXXXXXXX|XXXXXXXXXXXX11XXXXXXXXXXX|XXXXXXXXXXXX11XXXXXXXXXXX|XXXXXXXXXXXX11XXXXXXXXXXX"
        },
        new()
        {
            Id = "floorlobby_c", Name = "floorlobby_c", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXXXXXX|XXX0000000000000000XXXXXXX0|XXX000000000000000000XXXX00|X00000000000000000000000000|X00000000000000000000000000|XXX000000000000000000000000|XXXXXXX00000000000000000000|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX1XX100000011111111111111|XXX1XX100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXXXXXXX0000XXXXXXXXXXXXXXX|XXXXXXXX0000XXXXXXXXXXXXXXX|XXXXXXXX0000XXXXXXXXXXXXXXX"
        },
        new()
        {
            Id = "floorlobby_b", Name = "floorlobby_b", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXXXXXX|XXX0000000000000000XXXXXXX0|XXX000000000000000000XXXX00|X00000000000000000000000000|X00000000000000000000000000|XXX000000000000000000000000|XXXXXXX00000000000000000000|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX1XX100000011111111111111|XXX1XX100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXXXXXXX0000XXXXXXXXXXXXXXX|XXXXXXXX0000XXXXXXXXXXXXXXX|XXXXXXXX0000XXXXXXXXXXXXXXX"
        },
        new()
        {
            Id = "floorlobby_a", Name = "floorlobby_a", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXXXXXX|XXXXXXXXXXXXXXXXXXXXXXXXXXX|XXX0000000000000000XXXXXXX0|XXX000000000000000000XXXX00|X00000000000000000000000000|X00000000000000000000000000|XXX000000000000000000000000|XXXXXXX00000000000000000000|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX1XX100000011111111111111|XXX1XX100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXX111100000011111111111111|XXXXXXXX0000XXXXXXXXXXXXXXX|XXXXXXXX0000XXXXXXXXXXXXXXX|XXXXXXXX0000XXXXXXXXXXXXXXX"
        },
        new()
        {
            Id = "cinema_a", Name = "cinema_a", DoorX = 20, DoorY = 27, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxxx1xx11111111xxxxxx|xxx1111111111111111xxxxx|xxx111xxxx1111111111xxxx|xxxx2xxxxxxxxxxxxxxxxxxx|xx3x3x333311xxxxxxxxxx11|xx3333333311111111111111|xx3333333311111111111111|xx3333333311111111122111|xx3333333311x22222222111|xx3333333311x22222222111|xx3333333311xxxxxxxxx111|xx3333333311111111111111|xx3333333311111111111111|xx3333333311111111111111|xx3333333311111xxxx11111|xx3333333311111xxxx11111|xx3333333311111xxxx11111|xx3333333311111xxxx11111|xx3333333311111xxxx11111|xx3333333311111xxxx11111|xx3333333311111xxxx11111|333333332111111xxxx11111|333333332111111111111111|333333332111111111111111|333333332111111111111111|xx3333332111111111111111|xxxxxxxxxxxxxxxxxxx11111|xxxxxxxxxxxxxxxxxxx11111|xxxxxxxxxxxxxxxxxxx11111"
        },
        new()
        {
            Id = "sport", Name = "sport", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "111222222222222222x2222|x11222222222222222x2222|x11222222222222222x2222|xx1x2222222222222211111|x11xx222222222222211111|x11xx222222x22222211111|x11xx222222x222222x1111|x11xx222222x222222x1111|x11xx2222222222222x1111|x11xxxxxxxxxxxxxxxx1111|x1111111111111111111111|x1111111111111111111111|x1111111111111111111111|x1111111111111111111111|xxxx1111111111111x1111x|111x1111111111111x1111x|111x1111111111111x1111x|111x1111111111111x1111x|111x11111xxxxxxxxxxxxxx|x11x1111xxxxxxxxxxxxxxx|xxxx111xxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "old_skool0", Name = "old_skool0", DoorX = 2, DoorY = 1, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xx0xxxxxxxxxxxxxx|0000000xxx00000xx|0000000x0000000xx|0000000xxxxxxxxxx|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|00000000000000000|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x|0000000000000000x"
        },
        new()
        {
            Id = "old_skool1", Name = "old_skool1", DoorX = 1, DoorY = 7, DoorZ = 6, DoorDirection = 2,
            HeightMap =
                "x6666666665432100|x6666666665432100|x6600000000000x00|x6600000000000000|x6600000000000000|x6600000000000000|x660000000000x000|666000000000x1111|x66000000000xx111|x66000000000x1111|x66000000000x1111|x55000000000x1111|x44000000000x1111|x33000000000x1111|x22000000000xx111|x11x00000000x1111|x00000000000x1111|x00000000000xx111"
        },
        new()
        {
            Id = "malja_bar_a", Name = "malja_bar_a", DoorX = 4, DoorY = 24, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxx44|xxxx444444444444|xxxx444444444444|xxxx444444444444|xxxx444444444444|xxxx444444444444|xxxxxxxxxxxxx333|1111111111111222|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|111111111xxxxxxx|xxx11111xxxxxxxx|11111111xxxxxxxx|11111111xxxxxxxx|11111111xxxxxxxx|11111111xxxxxxxx"
        },
        new()
        {
            Id = "malja_bar_b", Name = "malja_bar_b", DoorX = 4, DoorY = 24, DoorZ = 3, DoorDirection = 0,
            HeightMap =
                "6666333333333333|6666333333333333|6666333333333333|7766333333333333|7755333333333333|8855333333332223|8844333311111111|9944333311111111|9933333311111111|9933333311111111|9933333311111111|9933333311111111|9933333311111111|9933333311111111|9933333211111111|9933333211111111|9933333211111111|9933333311111111|99333333xxxxxxxx|99333333xxxxxxxx|xxx33333xxxxxxxx|xxx33333xxxxxxxx|3xx33333xxxxxxxx|xxx33333xxxxxxxx|xxx33333xxxxxxxx|xxx33333xxxxxxxx"
        },
        new()
        {
            Id = "bar_a", Name = "bar_a", DoorX = 5, DoorY = 1, DoorZ = 7, DoorDirection = 4,
            HeightMap =
                "xxxx8888xxxxxxxxxxx|xxxx7777xxxxxxxxxxx|xxxx6666xxxxxxxxxxx|xxx6666666555555555|xxx6666666555555555|xxx6666666555555555|xxx6666666555555555|xxx6666666555555555|xxx6666666555555555|xxx6666666555555555|xxx6666666555xxxxxx|xxx6666666555555555|xxx5555555555555555|xxx5555555555555555|xxx5555555555555555|xxx5555555555555555|xxx5555555555xxxxxx|xxx5555555555555555|xxx5555555555555555|xxx5555555555555555|xxx5555555555555555|xxx5555555555555555|xxx5555555555xxxxxx|xxxx555555555555555|55xx555555555555555|55xx555555555555555|5555555555555555555|5555555555555555555|xxxxxxxx55555xxxxxx|xxxxxxxxx5555xxxxxx|xxxxxxxxx5555xxxxxx|xxxxxxxxx5555xxxxxx|xxxxxxxxx4444xxxxxx|xxxxxxxxx3333xxxxxx"
        },
        new()
        {
            Id = "bar_b", Name = "bar_b", DoorX = 2, DoorY = 12, DoorZ = 4, DoorDirection = 2,
            HeightMap =
                "xxxxx4xxxxxxxxxxxx|xxxx4444444xxxxxxx|xxxx4444444xxxxxxx|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|654444444444444444|654444444444444444|654444444444444444|654444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxx444444444444444|xxxx44444444444444|xxxx33444444444444|xxxx22444444444444|xxxx2222222222xx44|xxxx2222222222xx44|xxxxx222222222xxxx|xxxxxx22222222xxxx|xxxxxx22222222xxxx|xxxxxx22222222xxxx|xxxxxx22222222xxxx|xxxxxx22222222xxxx|xxxxxx22222222xxxx"
        },
        new()
        {
            Id = "habburger", Name = "habburger", DoorX = 22, DoorY = 10, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "22222222222222222222xxx|22222222222222222222xxx|22222222222222222222xxx|22222222222222222222xxx|xxxxxxxxxxxxxxxx1111xxx|xxxxxxxxxxxxxxxx0000xxx|xxx00000000000000000xxx|00000000000000000000xxx|00000000000000000000xxx|00000000000000000000000|00000000000000000000000|00000000000000000000xxx|00000000000000000000xxx|00000000000000000000xxx|xxx00000000000000000xxx"
        },
        new()
        {
            Id = "pizza", Name = "pizza", DoorX = 5, DoorY = 27, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxx0000000|x11111x1xx000000|11xxxxx111x00000|11x1111111xx0000|11x1111111100000|xxx1111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|1111111111100000|11111111111xxxxx|1111111111xxxxxx|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|1111111111111111|11xx11xx11111111|xxxx11xxxxxxxxxx|xxxx11xxxxxxxxxx"
        },
        new()
        {
            Id = "bb_lobby_1", Name = "bb_lobby_1", DoorX = 14, DoorY = 19, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxx2222222222222222x|xxx2222222222222222x|xxx2222222222222222x|xxx2222222222222222x|xxx11111111111111111|11x11111111111111111|11x11111111111111111|11x11111111111111111|x1x11111111111111111|xxx11111111111111111|xxx11111111111111111|xxx11111111111111111|xxx11111111111111111|xxx11111111111111111|xxxxxxxxx00000000000|xxxxxxxxx00000000000|xxxxxxxxx00000000000|xxxxxxxxx00000000000|xxxxxxxxx00000000000|xxxxxxxxx00000000000|xxxxxxxxxxxxx000xxxx|xxxxxxxxxxxxx000xxxx|xxxxxxxxxxxxx000xxxx"
        },
        new()
        {
            Id = "snowwar_lobby_1", Name = "snowwar_lobby_1", DoorX = 41, DoorY = 36, DoorZ = 1,
            DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx11111xx1xxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx11111xx1111xxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxx111111xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxx111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxx111111111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxx1111x1111111111xxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "tv_studio", Name = "tv_studio", DoorX = 16, DoorY = 27, DoorZ = 4, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxx|xxxxx0x00000xxxxxxxx|xxxxx0x000000xxxxxxx|xxxxx0x000000xxxxxxx|xxxxx0x0xxx00000xx0x|xx0000x000000000xx00|xx00xxx000000000xx00|xxxxx00000000000xx00|x000000000000x000000|x0000000000000000000|x0000000000000000x00|00000000000000000x00|x000x000000000000x00|x0000000000000000x00|x0000000000000000x00|000x0000000000000000|000x0000000000000000|00000000000000xxx000|x0000000000000000000|xx00000000000000000x|xxx000000000000000xx|xxxxxxxxx1111xxxx0xx|xxxxxxxxx2222xxxxxxx|xxxxxxxxx3333xxxxxxx|xxxxxx44x4444x444xxx|xxxxx444444444444xxx|xxxxxx44444444444444|xxxxx4444x4444444444|xxxxx4444x4444444444|xxxxx4444x4444444xxx|xxxxx444444444444xxx|xxxxx444444444444xxx|xxxxxx44444444444xxx"
        },
        new()
        {
            Id = "cr_kitchen", Name = "cr_kitchen", DoorX = 7, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "X0XXXX000XXXX000X0X|X000000000000000000|X000000000000000000|X000000000000000XXX|X00XXXX00XXXX000XXX|X00XXXX00XXXX00XXXX|X00000000000000XXXX|X00000000000000XXXX|X00000000000000XXXX|X00XXXXXXXXXX00XXXX|X00XXXXXXXXXX00XXXX|X00XXXXXXXXXX000XXX|0000000000000000XXX|000000000000000XXXX|000000000000000XXXX|000XXX0000XXX00XXXX|000XXX0000XXX00XXXX|000000000000000XXXX|000000000000000XXXX|000000000000000XXXX|XXXXXXX00XXXXXXXXXX|XXXXXXX00XXXXXXXXXX|XXXXXXX00XXXXXXXXXX"
        },
        new()
        {
            Id = "club_mammoth", Name = "club_mammoth", DoorX = 6, DoorY = 16, DoorZ = 4, DoorDirection = 2,
            HeightMap =
                "xxxxxx4444444x4444xxxxxxxxxxxxx|xxxxxx4444444x444322xxxxxxxxxxx|xxxxxxxxxxxxxx444322xxxxxxxxxxx|x444444444444444442222xxxxxxxxx|4444444444444444442222xxxxxxxxx|4xxxxxxxxxxxxxxxxx2222xxxxxxxxx|4xxxxxxxxxx22222xx2222xxxxxxxxx|44xxxxxxxxx22222x2xxxxxxxxxxxxx|x4444444xxx22222x22xxxxxxxxxxxx|xx4444444xx22x22x222xxxxxxxxxxx|xxxxxxx444x22222xxxxxxxxxxxxxxx|xxxxxx444322222222211111111xxxx|xxxxxx444322222222211111111xxxx|xxxxxx444442222222211111111xxxx|xxx444444442222222211111111xxxx|xxx444444442222222211111111xxxx|xxx444444442222222211111111xxxx|xxx444444442222222211111111xxxx|xxxxxx4444422222222x1111111xxxx|xxxxxx4444422222222xxxxxxxxxxxx|xxxxxx4443222222222222222222xxx|xxxxxx4443xxxxxxx2xxxxx222xxxxx|xxxxxx444xxxxxxxxxxxxxxx22xxxxx|xxxxxx4xxxxxxxxxxxxx444422xxxxx|xxx4444xxxxxxxxxxxxx4444x2xxxxx|xxx566666666666666664444xxxxxxx|xxxx66666666666666664444xxxxxxx|xxxxxxx666666666666544xxxxxxxxx|xxxxxxx666666666666544xxxxxxxxx|xxxxxxx6666666666666xxxxxxxxxxx|xxxxxxx6666666666666xxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "ice_cafe", Name = "taivas_cafe", DoorX = 17, DoorY = 23, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx1111111000000000|xx1111111000000000|111111111000000000|111111111000000000|111111111000000000|111111111000000000|111111111000000000|11111111x000000000|11111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx111111x000000000|xx1111110000000000|xx1111111000000000|xx1111111000000000|xx1111111000000000|"
        },
        new()
        {
            Id = "netcafe", Name = "netcafe", DoorX = 22, DoorY = 12, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxxx1111xxxxxxxxxxx1xxxx|xxxxx1111111111111111xxxx|xxxxx1111111111111111xxxx|xxxxx1111111111111111xxxx|xxxxxxxx0000000000000xxxx|111111100000000000000xxxx|111111100000000000000xxxx|111111100000000000000xxxx|xxxx11100000000000000xxxx|x1xx11100000000000000xxxx|x1xx11100000000000000xxxx|x1xx111000000000000000000|x1xx111000000000000000000|xxxx111000000000000000000|xxxx11100000000000000xxxx|xxxx1110000000xx11111xxxx|xxxxx111110000x111111xxxx|xxxxxx111100001111111xxxx|xxxxxx111100001111111xxxx|xxxxxx111100001111111xxxx|xxxxxx111100001111111xxxx|xxxxxx111100001111111xxxx|xxxxxx111100001111111xxxx|xxxxx1111100001111111xxxx|"
        },
        new()
        {
            Id = "hallway0", Name = "hallway0", DoorX = 2, DoorY = 2, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxx000000001111111111111111xxxx|xxxx000000001111111111111111xxxx|00000000000011111111111111111111|00000000000011111111111111111111|00000000000011111111111111111111|00000000000011111111111111111111|xxxx000000001111111111111111xxxx|xxxx0000000x1111111111111111xxxx|xxxxxxxxxxxxx1111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallway9", Name = "hallway9", DoorX = 21, DoorY = 23, DoorZ = 0, DoorDirection = 7,
            HeightMap =
                "xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxx000000000000000000000000xxxx|xxxx000000000000000000000000xxxx|00000000000000000000000000000000|00000000000000000000000000000000|00000000000000000000000000000000|00000000000000000000000000000000|xxxx000000000000000000000000xxxx|xxxx000000000000000000000000xxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx000000000000xxxxxxxx|xxxxxxxxxxxx000000000000xxxxxxxx|xxxxxxxxxxxx000000000000xxxxxxxx|xxxxxxxxxxxx000000000000xxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallway2", Name = "hallway2", DoorX = 15, DoorY = 2, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx000xxxxxxxxxxx|xxxxxxxxxxxxxx000xxxxxxxxxxx|xxxxxxxxxxxxxx000xxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxx|xxxx11111111000000000000xxxx|xxxx11111111000000000000xxxx|1111111111110000000000000000|1111111111110000000000000000|1111111111110000000000000000|1111111111110000000000000000|xxxx11111111000000000000xxxx|xxxx11111111000000000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxx11111111xxxx00000000xxxx|xxxxxx1111xxxxxxxxxxxxxxxxxx|xxxxxx1111xxxxxxxxxxxxxxxxxx|xxxxxx1111xxxxxxxxxxxxxxxxxx|xxxxxx1111xxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallway1", Name = "hallway1", DoorX = 2, DoorY = 14, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx|xxxxxxxxxxxx0000000000000000xxxx|xxxxxxxxxxxx0000000000000000xxxx|xxxxxxxxxxxx00000000000000000000|xxxxxxxxxxxx00000000000000000000|xxxxxxxxxxxx00000000000000000000|xxxxxxxxxxxx00000000000000000000|xxxxxxxxxxxx0000000000000000xxxx|xxxxxxxxxxxx0000000000000000xxxx|xxxx1111111100000000xxxxxxxxxxxx|xxxx1111111100000000xxxxxxxxxxxx|11111111111100000000xxxxxxxxxxxx|11111111111100000000xxxxxxxxxxxx|11111111111100000000xxxxxxxxxxxx|11111111111100000000xxxxxxxxxxxx|xxxx1111111100000000xxxxxxxxxxxx|xxxx1111111100000000xxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallway3", Name = "hallway3", DoorX = 14, DoorY = 21, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxx1111xxxxxxxxxxxxxxxxxxxxxx|xxxxxx1111xxxxxxxxxxxxxxxxxxxxxx|xxxxxx1111xxxxxxxxxxxxxxxxxxxxxx|xxxxxx1111xxxxxxxxxxxxxxxxxxxxxx|xxxx111111111111111100000000xxxx|xxxx111111111111111100000000xxxx|11111111111111111111000000000000|11111111111111111111000000000000|11111111111111111111000000000000|11111111111111111111000000000000|xxxx111111111111111100000000xxxx|xxxx111111111111111100000000xxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx|xxxxxxxxxxxxxx1111xxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallway4", Name = "hallway4", DoorX = 29, DoorY = 3, DoorZ = 1, DoorDirection = 6,
            HeightMap =
                "xxxx000000001111111111111111xxxx|xxxx000000001111111111111111xxxx|00000000000011111111111111111111|00000000000011111111111111111111|00000000000011111111111111111111|00000000000011111111111111111111|xxxx000000001111111111111111xxxx|xxxx000000001111111111111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxx11111111xxxx|xxxxxxxxxxxxxxxxxxxxxx1111xxxxxx|xxxxxxxxxxxxxxxxxxxxxx1111xxxxxx|xxxxxxxxxxxxxxxxxxxxxx1111xxxxxx|xxxxxxxxxxxxxxxxxxxxxx1111xxxxxx"
        },
        new()
        {
            Id = "hallway5", Name = "hallway5", DoorX = 14, DoorY = 2, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx11xxxxxx1111xx|xxxxxxxxxxxxxx111xxxxx1111xx|xxxxxxxxxxxxxx1111xxxx1111xx|xxxxxxxxxxxxxx1111xxxx1111xx|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxxxxxxxxxx1111111111111111|xxxx000000001111111111111111|xxxx000000001111111111111111|0000000000001111111111111111|0000000000001111111111111111|0000000000001111111111111111|0000000000001111111111111111|xxxx000000001111111111111111|xxxx0000000x1111111111111111|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx|xxxxxxxxxxxx11111111xxxxxxxx"
        },
        new()
        {
            Id = "hallway8", Name = "hallway8", DoorX = 15, DoorY = 3, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx00xxxx0000|xxxxxxxxxxxxxx000xxx0000|xxxxxxxxxxxxxx0000xx0000|xxxxxxxxxxxxxx0000xx0000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111000000000000|xxxx11111111xxxx00000000|xxxx11111111xxxx00000000|111111111111xxxx00000000|111111111111xxxx00000000|111111111111xxxx00000000|111111111111xxxx00000000|xxxx11111111xxxx00000000|xxxx11111111xxxx00000000|xxxxxxxxxxxxxxxxxx0000xx|xxxxxxxxxxxxxxxxxx0000xx|xxxxxxxxxxxxxxxxxx0000xx|xxxxxxxxxxxxxxxxxx0000xx"
        },
        new()
        {
            Id = "hallway7", Name = "hallway7", DoorX = 7, DoorY = 2, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "xxxxxx11xxxxxxxxxxxx|xxxxxx111xxxxxxxxxxx|xxxxxx1111xxxxxxxxxx|xxxxxx1111xxxxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx111111111111xxxx|xxxx111111111111xxxx|xxxx111111111111xxxx|xxxx111111111111xxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx11111111xxxxxxxx|xxxx000000000000xxxx|xxxx000000000000xxxx|00000000000000000000|00000000000000000000|00000000000000000000|00000000000000000000|xxxx000000000000xxxx|xxxx000000000000xxxx"
        },
        new()
        {
            Id = "hallway6", Name = "hallway6", DoorX = 1, DoorY = 10, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxx1111111111111111xxxx|xxxx1111111111111111xxxx|xxxx1111111111111111xxxx|xxxx1111111111111111xxxx|xxxx1111xxxxxxxxxxxxxxxx|xxxx1111xxxxxxxxxxxxxxxx|xxxx1111xxxxxxxxxxxxxxxx|xxxx1111xxxxxxxxxxxxxxxx|xxxx1111111100000000xxxx|xxxx1111111100000000xxxx|111111111111000000000000|111111111111000000000000|111111111111000000000000|111111111111000000000000|xxxx1111111100000000xxxx|xxxx1111111100000000xxxx|xxxxxxxx1111xxxxxxxxxxxx|xxxxxxxx1111xxxxxxxxxxxx|xxxxxxxx1111xxxxxxxxxxxx|xxxxxxxx1111xxxxxxxxxxxx|xxxxxxxx111111111111xxxx|xxxxxxxx111111111111xxxx|xxxxxxxx111111111111xxxx|xxxxxxxx111111111111xxxx"
        },
        new()
        {
            Id = "hallway10", Name = "hallway10", DoorX = 3, DoorY = 23, DoorZ = 1, DoorDirection = 1,
            HeightMap =
                "xxxxxxxxxx00000000xxxx|xxxxxxxxxx00000000xxxx|xxxxxxxxxx00000000xxxx|xxxxxxxxxx00000000xxxx|xx1111xxxx0000xxxxxxxx|xx1111xxxx0000xxxxxxxx|xx1111xxxx0000xxxxxxxx|xx1111xxxx0000xxxxxxxx|11111111xx0000000000xx|11111111xx0000000000xx|11111111xx0000000000xx|11111111xx0000000000xx|11111111xxxxxxxx0000xx|11111111xxxxxxxx0000xx|11111111xxxxxxxx0000xx|11111111xxxxxxxx0000xx|1111111111111111000000|1111111111111111000000|1111111111111111000000|1111111111111111000000|1111111111111111000000|1111111111111111000000|1111111111111111000000|1111111111111111000000|xx1111xxxxxxxxxxxxxxxx|xx1111xxxxxxxxxxxxxxxx|xx1111xxxxxxxxxxxxxxxx|xx1111xxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallway11", Name = "hallway11", DoorX = 20, DoorY = 3, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxx1111111100000000xxxx|xxxx1111111100000000xxxx|111111111111000000000000|111111111111000000000000|111111111111000000000000|111111111111000000000000|xxxx1111111100000000xxxx|xxxx1111111100000000xxxx|xxxxxxxxxxxx000000000000|xxxxxxxxxxxx000000000000|xxxxxxxxxx00000000000000|xxxxxxxxxx00000000000000|xxxxxxxxxx00000000000000|xxxxxxxxxx00000000000000|xxxxxxxxxxxx000000000000|xxxxxxxxxxxx000000000000|xxxxxxxxxxxx000000000000|xxxxxxxxxxxx000000000000|xxxxxxxx000000000000xxxx|xxxxxxxx000000000000xxxx|xxxxxxxx000000000000xxxx|xxxxxxxx000000000000xxxx"
        },
        new()
        {
            Id = "star_lounge", Name = "star_lounge", DoorX = 36, DoorY = 35, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx2222x4444442222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222x444x32222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222xx4xx22222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222222222222222111xxxxxxxxx|xxxxxxxxxxxxxxxxxxxxx22222222222222222111xxxxxxxxx|xxxxxxxxxxxxxxxx3333x22222222222222xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx3333x22222222222222xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx3333x22222222221111xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx3333xx2x22222220000xxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx333333332222222000000xxxxxxxxxxxxx|xxxxxxxxxxxxxxxx333333332222222x0000000xxxxxxxxxxx|xxxxxxxxxxxxxxxxx33333332222222x0000000xxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxx222222000000xxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "orient", Name = "orient", DoorX = 32, DoorY = 20, DoorZ = 1, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx|xxxxxxxxxxxxxx1000000000xxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx1xx000x000xx111x111xxx|xxxxxxxxxxxxxx1xx000x000xxxxxx1111xx|xxxxxxxxxxxxxx1xx000x000x111111111xx|xxxxxxxxxxxxxx1xx000x000x111111111xx|xxx111111111111xx000x000x111111111xx|xxx1xxxxxxxxxxxxx000x000x111111111xx|xxx1x1111111111000000000x111111111xx|xxx1x1111111111000000000xx1111111xxx|xxx1x11xxxxxx11000000000xx1111111100|xxx111xxxxxxx11000000000011111111100|xxx111xxxxxxx11000000000011111111100|xxxxx1xxxxxxx11000000000011111111100|xxxxx11xxxxxx11000000000xx1111111100|xxxxx1111111111000000000xx1111111xxx|xxxxx1111111111xx000x000x111111111xx|xxxxxxxxxxxxxxxxx000x000x111111111xx|xxxxxxxxxxxxxxxxx000x000x111111111xx|xxxxxxxxxxxxxxxxx000x000x111111111xx|xxxxxxxxxxxxxxxxx000x000x111111111xx|xxxxxxxxxxxxxxxxx000x00xx11xxxx111xx|xxxxxxxxxxxxxxxxxxxxxxxxxx11111111xx|"
        },
        new()
        {
            Id = "entryhall", Name = "entryhall", DoorX = 17, DoorY = 18, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xx11xxxx11xxxx11xxxx|x1111111111111111111|11111111111111111111|11111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|x1111111111111111111|xxxxxxxxxxxxxxxxx11x"
        },
        new()
        {
            Id = "hallA", Name = "hallA", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "11xxxxxxxxxxxxxxx|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111"
        },
        new()
        {
            Id = "hallB", Name = "hallB", DoorX = 1, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "x11xxxxxxxxxxxxxxxx|1111111111111111111|1111111111111111111|1111111111111111111|1111111111111111111|1111111111111111111|1111111111111111111|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx|111111xxxxxxxxxxxxx"
        },
        new()
        {
            Id = "hallC", Name = "hallC", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "11xxxxxxxxxxxxxxx|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111"
        },
        new()
        {
            Id = "hallD", Name = "hallD", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "11xxxxxxxxxxxxxxx|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111|11111111111111111"
        },
        new()
        {
            Id = "model_s", Name = "model_s", DoorX = 0, DoorY = 3, DoorZ = 0, DoorDirection = 2,
            HeightMap = "xxxxxxx|x00000x|x00000x|000000x|x00000x|x00000x|x00000x|x00000x|xxxxxxx"
        },
        new()
        {
            Id = "emperors", Name = "emperors", DoorX = 11, DoorY = 31, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxx444xxxx4444xxxxxx|xxxx2x4444xxxx44444x2xxx|xxxx2x44444x4x44444x2xxx|xxxx2x4444444444444x2xxx|xxxx2x33xx33333xx33x2xxx|xxxx2222xx22222xx2222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22xx222222222xx22xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222222222222222xxx|xxxx22222xx22x2222222xxx|xxxxx2xx2xx22xxx2xx2xxxx|xxxxxxxxxxx11xxxxxxxxxxx|xxxxxxxxxxx00xxxxxxxxxxx|xxxxxxxxxxx00xxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx"
        },
        new()
        {
            Id = "beauty_salon1", Name = "beauty_salon1", DoorX = 14, DoorY = 3, DoorZ = 0, DoorDirection = 1,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxxxxxxxxxxxx|xxxxxxxxxxxxxx0xxxxxxxxx|xxxxxxx000000000000000xx|xxxxxx0000000000000000xx|xxxxx000000000000xxxxxxx|xxxx000000000000000000xx|xxx0000000000000000000xx|xxx0000000000000000000xx|xxx0000000000000000000xx|xxxxxxxxxxxxxxxx000000xx|xx0000000000000x000000xx|000000000000000x000000xx|000000000000000x000000xx|000000000000000x000000xx|00x000000000000x000000xx|00xxxxxxxxxxxxxx000000xx|00xxxxxxxxxxxxxx000000xx|00x0000000000000000000xx|00x0000000000000000000xx|00x0000000000000000000xx|0000000000000000000000xx|x000000000000000000000xx|xxx0000000000000000000xx"
        }
    };
}