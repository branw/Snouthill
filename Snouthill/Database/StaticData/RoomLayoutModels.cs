using Snouthill.Database.Models;

namespace Snouthill.Database.StaticData;

public class RoomLayoutModels
{
    public static readonly IEnumerable<RoomLayoutModel> Models = new List<RoomLayoutModel>
    {
        new()
        {
            Id = "model_a", Name = "model_a", DoorX = 3, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxx00000000\rxxxxxxxxxxxx\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_b", Name = "model_b", DoorX = 0, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxxx0000000\rxxxxx0000000\rxxxxx0000000\rxxxxx0000000\rx00000000000\rx00000000000\rx00000000000\rx00000000000\rx00000000000\rx00000000000\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_c", Name = "model_c", DoorX = 4, DoorY = 7, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_d", Name = "model_d", DoorX = 4, DoorY = 7, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxx000000x\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_e", Name = "model_e", DoorX = 1, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxx0000000000\rxx0000000000\rxx0000000000\rxx0000000000\rxx0000000000\rxx0000000000\rxx0000000000\rxx0000000000\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_f", Name = "model_f", DoorX = 2, DoorY = 5, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxxxxx0000x\rxxxxxxx0000x\rxxx00000000x\rxxx00000000x\rxxx00000000x\rxxx00000000x\rx0000000000x\rx0000000000x\rx0000000000x\rx0000000000x\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_g", Name = "model_g", DoorX = 1, DoorY = 7, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxx\rxxxxxxxxxxxxx\rxxxxxxx00000x\rxxxxxxx00000x\rxxxxxxx00000x\rxx1111000000x\rxx1111000000x\rxx1111000000x\rxx1111000000x\rxx1111000000x\rxxxxxxx00000x\rxxxxxxx00000x\rxxxxxxx00000x\rxxxxxxxxxxxxx\rxxxxxxxxxxxxx\rxxxxxxxxxxxxx\rxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_h", Name = "model_h", DoorX = 4, DoorY = 4, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxx111111x\rxxxxx111111x\rxxxxx111111x\rxxxxx111111x\rxxxxx111111x\rxxxxx000000x\rxxxxx000000x\rxxx00000000x\rxxx00000000x\rxxx00000000x\rxxx00000000x\rxxxxxxxxxxxx\rxxxxxxxxxxxx\rxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_i", Name = "model_i", DoorX = 0, DoorY = 10, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxx\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rx0000000000000000\rxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_j", Name = "model_j", DoorX = 0, DoorY = 10, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxx0000000000\rxxxxxxxxxxx0000000000\rxxxxxxxxxxx0000000000\rxxxxxxxxxxx0000000000\rxxxxxxxxxxx0000000000\rxxxxxxxxxxx0000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx0000000000xxxxxxxxxx\rx0000000000xxxxxxxxxx\rx0000000000xxxxxxxxxx\rx0000000000xxxxxxxxxx\rx0000000000xxxxxxxxxx\rx0000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_k", Name = "model_k", DoorX = 0, DoorY = 13, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx00000000\rxxxxxxxxxxxxxxxxx00000000\rxxxxxxxxxxxxxxxxx00000000\rxxxxxxxxxxxxxxxxx00000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rx000000000000000000000000\rx000000000000000000000000\rx000000000000000000000000\rx000000000000000000000000\rx000000000000000000000000\rx000000000000000000000000\rx000000000000000000000000\rx000000000000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_l", Name = "model_l", DoorX = 0, DoorY = 16, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxx\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rx00000000xxxx00000000\rxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_m", Name = "model_m", DoorX = 0, DoorY = 15, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rx0000000000000000000000000000\rx0000000000000000000000000000\rx0000000000000000000000000000\rx0000000000000000000000000000\rx0000000000000000000000000000\rx0000000000000000000000000000\rx0000000000000000000000000000\rx0000000000000000000000000000\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxx00000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_n", Name = "model_n", DoorX = 0, DoorY = 16, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxx\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx000000xxxxxxxx000000\rx000000x000000x000000\rx000000x000000x000000\rx000000x000000x000000\rx000000x000000x000000\rx000000x000000x000000\rx000000x000000x000000\rx000000xxxxxxxx000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rx00000000000000000000\rxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_o", Name = "model_o", DoorX = 0, DoorY = 18, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxx00000000xxxx\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rx111111100000000000000000\rx111111100000000000000000\rx111111100000000000000000\rx111111100000000000000000\rx111111100000000000000000\rx111111100000000000000000\rx111111100000000000000000\rx111111100000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxx0000000000000000\rxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_p", Name = "model_p", DoorX = 0, DoorY = 23, DoorZ = 2, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxx\rxxxxxxx222222222222\rxxxxxxx222222222222\rxxxxxxx222222222222\rxxxxxxx222222222222\rxxxxxxx222222222222\rxxxxxxx222222222222\rxxxxxxx22222222xxxx\rxxxxxxx11111111xxxx\rx222221111111111111\rx222221111111111111\rx222221111111111111\rx222221111111111111\rx222221111111111111\rx222221111111111111\rx222221111111111111\rx222221111111111111\rx2222xx11111111xxxx\rx2222xx00000000xxxx\rx2222xx000000000000\rx2222xx000000000000\rx2222xx000000000000\rx2222xx000000000000\rx2222xx000000000000\rx2222xx000000000000\rxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_q", Name = "model_q", DoorX = 10, DoorY = 4, DoorZ = 2, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxx22222222\rxxxxxxxxxxx22222222\rxxxxxxxxxxx22222222\rxxxxxxxxxxx22222222\rxxxxxxxxxxx22222222\rxxxxxxxxxxx22222222\rx222222222222222222\rx222222222222222222\rx222222222222222222\rx222222222222222222\rx222222222222222222\rx222222222222222222\rx2222xxxxxxxxxxxxxx\rx2222xxxxxxxxxxxxxx\rx2222211111xx000000\rx222221111110000000\rx222221111110000000\rx2222211111xx000000\rxx22xxx1111xxxxxxxx\rxx11xxx1111xxxxxxxx\rx1111xx1111xx000000\rx1111xx111110000000\rx1111xx111110000000\rx1111xx1111xx000000\rxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "model_r", Name = "model_r", DoorX = 10, DoorY = 4, DoorZ = 3, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxx33333333333333\rxxxxxxxxxxx33333333333333\rxxxxxxxxxxx33333333333333\rxxxxxxxxxxx33333333333333\rxxxxxxxxxxx33333333333333\rxxxxxxxxxxx33333333333333\rxxxxxxx333333333333333333\rxxxxxxx333333333333333333\rxxxxxxx333333333333333333\rxxxxxxx333333333333333333\rxxxxxxx333333333333333333\rxxxxxxx333333333333333333\rx4444433333xxxxxxxxxxxxxx\rx4444433333xxxxxxxxxxxxxx\rx44444333333222xx000000xx\rx44444333333222xx000000xx\rxxx44xxxxxxxx22xx000000xx\rxxx33xxxxxxxx11xx000000xx\rxxx33322222211110000000xx\rxxx33322222211110000000xx\rxxxxxxxxxxxxxxxxx000000xx\rxxxxxxxxxxxxxxxxx000000xx\rxxxxxxxxxxxxxxxxx000000xx\rxxxxxxxxxxxxxxxxx000000xx\rxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "newbie_lobby", Name = "newbie_lobby", DoorX = 2, DoorY = 11, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxx000000\rxxxxx0xxxxxxxxxx000000\rxxxxx00000000xxx000000\rxxxxx000000000xx000000\r0000000000000000000000\r0000000000000000000000\r0000000000000000000000\r0000000000000000000000\r0000000000000000000000\rxxxxx000000000000000xx\rxxxxx000000000000000xx\rx0000000000000000000xx\rx0000000000000000xxxxx\rxxxxxx00000000000xxxxx\rxxxxxxx0000000000xxxxx\rxxxxxxxx000000000xxxxx\rxxxxxxxx000000000xxxxx\rxxxxxxxx000000000xxxxx\rxxxxxxxx000000000xxxxx\rxxxxxxxx000000000xxxxx\rxxxxxxxx000000000xxxxx\rxxxxxx00000000000xxxxx\rxxxxxx00000000000xxxxx\rxxxxxx00000000000xxxxx\rxxxxxx00000000000xxxxx\rxxxxxx00000000000xxxxx\rxxxxx000000000000xxxxx\rxxxxx000000000000xxxxx\r"
        },
        new()
        {
            Id = "theater", Name = "theater", DoorX = 20, DoorY = 27, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXX111111111XXXXXXX\rXXXXXXX11111111100000XX\rXXXX00X11111111100000XX\rXXXX00x11111111100000XX\r4XXX00X11111111100000XX\r4440000XXXXXXXXX00000XX\r444000000000000000000XX\r4XX000000000000000000XX\r4XX0000000000000000000X\r44400000000000000000000\r44400000000000000000000\r44X0000000000000000O000\r44X11111111111111111000\r44X11111111111111111000\r33X11111111111111111000\r22X11111111111111111000\r22X11111111111111111000\r22X11111111111111111000\r22X11111111111111111000\r22X11111111111111111000\r22211111111111111111000\r22211111111111111111000\rXXXXXXXXXXXXXXXXXXXX00X\rXXXXXXXXXXXXXXXXXXXX00X\r"
        },
        new()
        {
            Id = "library", Name = "library", DoorX = 20, DoorY = 3, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxx11111xx1xx1x111111x\rxxxxxxxxxxxx111111xx1xx11111111x\rxx111xxxxxxx111111xx1xx11111111x\rxx111xxxxxxx1111111111111111111x\rxx111xxxxxxx1111111111111111111x\rxx111xxxxxxx1111111111111111111x\rxx111xxxxxxx1111111111111xxxxxxx\rxx111xxxxxx11111111111111111111x\rxx111xxxxxx11111111111111111111x\rxx111xxxxxx11111111111111111111x\rxx111xxxxxx11111111111111xxxxxxx\rxx111xxxxxxxx111111111111111111x\rxx111xx11111x111111111111111111x\rxx111xx11111x111111111111111111x\rxx111xxxxx11x11111111x111xxxxxxx\rxx111xxxxxxxx11111111xx11111111x\rxx111xxx1111111111111xxx1111111x\rxx111xxx1111111111111xxxx111111x\rxxx111xx1111111111x11xxxx000000x\rxxxxx1111xx1111111x11xxxx000000x\rxxxxxxxxxxxx111111x11xxxx000000x\rxxxxxxxxxxxx11xx11x11xxxx000000x\rxxxxxxxxxxxx11xx11x11xxxx000000x\rxxxxxxxxxxxx11xx11x11xxxx000000x\rxxxxxxxxxxxx11xx11x11xxxx000000x\rxxxxxxxxxxxx11xx11x11xxxx000000x\rxxxxxxxxxxxx11xx11x111xxx000000x\rxxxxxxxxxxxxxxxxxxxx11xxx000000x\rxxxxxxxxxxxxxxxxxxxx11xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxx22222xxxxxxx\rxxxxxxxxxxxxxxxxxxxx22222xxxxxxx\rxxxxxxxxxxxxxxxxxxxx22222xxxxxxx\rxxxxxxxxxxxxxxxxxxxx22222xxxxxxx\rxxxxxxxxxxxxxxxxxxxx22222xxxxxxx\rxxxxxxxxxxxxxxxxxxxx22222xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "floatinggarden", Name = "floatinggarden", DoorX = 2, DoorY = 21, DoorZ = 5, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxxxx333333xxxxxxxxx\rxxxxxxxxxxxxxxxx3xxxx3xxxxxxxxx\rxxxxxxxxxxxxxxxx3xxxx3xxxxxxxxx\rxxxxxxxxxxxxxxxx3xxxx3xxxxxxxxx\rxxxxxxxxxxxxxxx223xxx33xxxxxxxx\rxxxxxxxxxxxxxxx11xxx33333xxxxxx\rxxxxxxxxxxxxxxxx11xx3333333xxxx\rxxxxxxxxxxxxxxxx11xx33333333xxx\rxxxxxxxxxxxxxxxxx11xxxxxxxx3xxx\rxxxxxxxxxxxxxxxxxx11xxxx3333xxx\rxxxxxxxxxxxxxxxxxxx1xxxx33333xx\rxxxxxxxxxxxxxxxxxxx1xxx3333333x\r555xxxxxxxxxxx1111111x333333333\r555xxxxxxxxxxx21111111xxxxxx333\r555xxxxxxxxxxx22111111111xxxxxx\r555xxxxxxxxxxx222xxxxxxx111xxxx\r555xxxxxxxxxxx22xxxxxxxxxx1xxxx\r555xxxxxxxxxxx23333333333x111xx\r555xxxxxxxx33333333333333x111xx\r555xxxxxxxx333333x3333333x111xx\r555xxxxxxxx33333333333333x111xx\r555xxxxxxxx33x33333333333x111xx\r555xxxxxxxx33x33x33333333x111xx\r555xxxxxxxx33x33x33333333x111xx\r5554333333333x333x3333333x111xx\rx554333333xxxx33xxxxxxxxxx111xx\rxxxxxxxxx3xxxx333221111111111xx\rxxxxxxxxx3xxxx333221111111111xx\rxxxxxxxxx33333333xx1111x11x11xx\rxxxxxxxxx33333333111xxx11xxxxxx\rxxxxxxxxxxxxxx33311xxxx11xxxxxx\rxxxxxxxxxxxxxx33311xxxx11xxxxxx\rxxxxxxxxxxxxxx333x1xxxx11xxxxxx\rxxxxxxxxxxxxxx333x1xx111111xxxx\rxxxxxxxxxxxxxx33311xx111111xxxx\rxxxxxxxxxx333333311xx111111xxxx\rxxxxxxxxxxx33333311xx111111xxxx\rxxxxxxxxxxxxxxxx111xxxxxxxxxxxx\rxxxxxxxxxxxxxxx111xxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "sunset_cafe", Name = "sunset_cafe", DoorX = 34, DoorY = 40, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxx00000xx00000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000000xxx0000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000000xxxx000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx0000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "pool_a", Name = "pool_a", DoorX = 2, DoorY = 25, DoorZ = 7, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx7xxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx777xxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx7777777xxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx777777777xxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx7xxx777777xxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx7x777777777xxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx7xxx77777777xxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx7x777777777x7xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx7xxx7777777777xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx777777777777xxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx77777777777x2111xxxxxxxxxxxx\rxxxxxxxxxxxxxxx7777777777x221111xxxxxxxxxxx\rxxxxxxxxx7777777777777777x2211111xxxxxxxxxx\rxxxxxxxxx7777777777777777x22211111xxxxxxxxx\rxxxxxxxxx7777777777777777x222211111xxxxxxxx\rxxxxxx77777777777777777777x222211111xxxxxxx\rxxxxxx7777777xx777777777777x222211111xxxxxx\rxxxxxx7777777xx77777777777772222111111xxxxx\rxxxxxx777777777777777777777x22221111111xxxx\rxx7777777777777777777777x322222211111111xxx\r77777777777777777777777x33222222111111111xx\r7777777777777777777777x333222222211111111xx\rxx7777777777777777777x333322222222111111xxx\rxx7777777777777777777333332222222221111xxxx\rxx777xxx777777777777733333222222222211xxxxx\rxx777x7x77777777777773333322222222222xxxxxx\rxx777x7x7777777777777x33332222222222xxxxxxx\rxxx77x7x7777777777777xx333222222222xxxxxxxx\rxxxx77777777777777777xxx3222222222xxxxxxxxx\rxxxxx777777777777777777xx22222222xxxxxxxxxx\rxxxxxx777777777777777777x2222222xxxxxxxxxxx\rxxxxxxx777777777777777777222222xxxxxxxxxxxx\rxxxxxxxx7777777777777777722222xxxxxxxxxxxxx\rxxxxxxxxx77777777777777772222xxxxxxxxxxxxxx\rxxxxxxxxxx777777777777777222xxxxxxxxxxxxxxx\rxxxxxxxxxxx77777777777777x2xxxxxxxxxxxxxxxx\rxxxxxxxxxxxx77777777777777xxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxx777777777777xxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx7777777777xxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx777777xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx7777xxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxx77xxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "pub_a", Name = "pub_a", DoorX = 15, DoorY = 25, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxx2222211111xxx\rxxxxxxxxx2222222211111xxx\rxxxxxxxxx2222222211111xxx\rxxxxxxxxx2222222211111xxx\rxxxxxxxxx2222222222111xxx\rxxxxxxxxx2222222222111xxx\rxxxxxxxxx2222222222000xxx\rxxxxxxxxx2222222222000xxx\rxxxxxxxxx2222222222000xxx\rxxxxxxxxx2222222222000xxx\rx333333332222222222000xxx\rx333333332222222222000xxx\rx333333332222222222000xxx\rx333333332222222222000xxx\rx333333332222222222000xxx\rx333332222222222222000xxx\rx333332222222222222000xxx\rx333332222222222222000xxx\rx333332222222222222000xxx\rx333333332222222222000xxx\rxxxxx31111112222222000xxx\rxxxxx31111111000000000xxx\rxxxxx31111111000000000xxx\rxxxxx31111111000000000xxx\rxxxxx31111111000000000xxx\rxxxxxxxxxxxxxxx00xxxxxxxx\rxxxxxxxxxxxxxxx00xxxxxxxx\rxxxxxxxxxxxxxxx00xxxxxxxx\rxxxxxxxxxxxxxxx00xxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "md_a", Name = "md_a", DoorX = 3, DoorY = 4, DoorZ = 7, DoorDirection = 2,
            HeightMap =
                "xxxxxxxx77xxxxxxxxxxxxxxxx\rxxxxxxxx77xxxxxxxxxxxxxxxx\rxxxxxx77777x77xxxxxxxxxxxx\rxxx77777777777xxx44xxxxxxx\r77777777777777xx444444444x\r777777777777777xx44444444x\rxxx777777777777xx44444444x\rxxxx7777777777xxx44444444x\r7777777777777777744448444x\r7777777777777x4x744448444x\r777777777777x444444448444x\r7777777777774444444448444x\r7777777777774444444448444x\r777777777777x444444448444x\r7777777777777x44444448444x\rxxx777777777777x444448444x\rxxx7777777777777444448444x\rxxx7777777777777444448444x\rxxx777777777777x444448444x\rxxx77777777777x4444444444x\rxxxx777777777444444444444x\rxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "picnic", Name = "picnic", DoorX = 16, DoorY = 5, DoorZ = 2, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxx22222xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r22xxxxxxxxxxxxx22xxxxxxxxxxxxxxxxxxxxx\r2222222222222222222x222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222xxx222222222222222222222222\r2222222222xx33x22222222222222222222222\r222222222xx3333x2222222222222222222222\r222222222x333333x222222222222222222222\r222222222x333333x222222222222222222222\r2222222222x3332x2222222222222222222222\r22222222222x33x22222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222x22222xxxx22222222222222222222\r22222222222222xxxx22222222222222222222\r22222222222222xxx222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r22222222222222222222222222222222222222\r"
        },
        new()
        {
            Id = "park_a", Name = "park_a", DoorX = 2, DoorY = 15, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0xxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00xxxxxxxxxxxx\rxxxxxxxxxxxxx0x00xxxxxxxxxxx0x000xxxxxxxxxxx\rxxxxxxxxxxxx0000000000000000000000xxxxxxxxxx\rxxxxxxxxxxx000000000000000000000000xxxxxxxxx\rxxxxxxxxxxx0000000000000000000000000xxxxxxxx\rxxxxxxxxxxx00000000000000000000000000xxxxxxx\rxxxxxxxx000000000000000000000000000000xxxxxx\rxxxxxxx00000000000000000000000000000000xxxxx\rxxxxxxx000000000000000000000000000000000xxxx\rxxxxxxx0000000000000000000000000000000000xxx\rxxxxxxxxx000000000000000000000000000000000xx\r00000000000000000000xx00000000000000000000xx\r0000000000000000000xxxx00000000000xxxxxxx0xx\r0000000000000000000xxxx00000000000x00000xxxx\rxxxxx00x0000000000xxxxx0xxxxxx0000x0000000xx\rxxxxx0000000000000xxxxx0xx000x0000x000000xxx\rxxxxx0000000000000xxxxx0x000000000x00000xxxx\rxxxxx000000x0000000xxxx0x000000000xxx00xxxxx\rxxxxxxxx000x0000000xxx00xxx000000x0000xxxxxx\rxxxxxxxx000x000000xxxx0x0000000000000xxxxxxx\rxxxxxxxx000x000000011100000000000000xxxxxxxx\rxxxxxxxx000x00000001110000000000000xxxxxxxxx\rxxxxxxxxx00x0000000111x00000000x00xxxxxxxxxx\rxxxxxxxxxx0x0000000xxx0000000xxxxxxxxxxxxxxx\rxxxxxxxxxxxx000000xxxx0000000xxxxxxxxxxxxxxx\rxxxxxxxxxxxx000000xxx00xxxxx00xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxx0xx000x00xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxx0x000000xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxx0x00000xxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxxxx00xxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxxxx0xxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "park_b", Name = "park_b", DoorX = 11, DoorY = 2, DoorZ = 0, DoorDirection = 6,
            HeightMap = "0000x0000000\r0000xx000000\r000000000000\r00000000000x\r000000000000\r00x0000x0000\r"
        },
        new()
        {
            Id = "pool_b", Name = "pool_b", DoorX = 9, DoorY = 21, DoorZ = 7, DoorDirection = 1,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx7xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx777xxxxxxxxxxx\rxxxxxxxxxxxxxxxxxx8888888x7xxx77777xxxxxxxxxx\rxxxxxxxxxxxxxxxxxx8888888x7xxx777777xxxxxxxxx\rxxxxxxxxxxxxxxxx88xxxxx77x7x777777777xxxxxxxx\rxxxxxxxxxxxxxxxx88x7777777777777777777xxxxxxx\rxxxxxxxxxxxxxxxx88x77777777777777777777xxxxxx\rxxxxxxxxxxxxxx9988x77777777777777777777xxxxxx\rxxxxxxxxxxxxxx9988x7777777777777777777x00xxxx\rxxxxxxxxxxxxxx9988x777777777777777777x0000xxx\rxxxxxxxxxxxxxx9988x7777777x0000000000000000xx\rxxxxxxxxxxxxxx9988x777777x000000000000000000x\r7777777777xxxx9988777777x0x0000000000000000xx\rx7777777777xxx998877777x000x00000000000000xxx\rxx7777777777xx99887777x00000x000000000000xxxx\rxxx7777777777x9988777x0000000x0000000000xxxxx\rxxxx777777777x777777x00000000x000000000xxxxxx\rxxxxx777777777777777000000000x00000000xxxxxxx\rxxxxxx77777777777777000000000x0000000xxxxxxxx\rxxxxxxx777777x7777770000000000xxxx00xxxxxxxxx\rxxxxxxxx77777777777xx0000000000000xxxxxxxxxxx\rxxxxxxxxx777777110000x000000000000xxxxxxxxxxx\rxxxxxxxxxx7x77x1100000x0000000000xxxxxxxxxxxx\rxxxxxxxxxxx777x11000000x00000000xxxxxxxxxxxxx\rxxxxxxxxxxxx771110000000x000000xxxxxxxxxxxxxx\rxxxxxxxxxxxxx111100000000x0000xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx11100000000x000xxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx1100000000x00xxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx110000000x0xxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx110000000xxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxx1100000xxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxx11000xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxx110xxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "ballroom", Name = "ballroom", DoorX = 13, DoorY = 6, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xxxx4444444444444444444\rxxxx4444444444444444444\rxxxx4444444444444444444\rxxxx33x2222444442222x33\rxxxx2222222x00xx2222222\rxxxx22222220000x2222222\rxxxx11x0000x000x0000x11\rxxxx0000000000000000000\r11100000000000000000000\r11100000000000000000000\r11100000000000000000000\rxxxx0000000000000000000\r22210000000000000000000\r22210000000000000000000\r22210000000000000000000\rxxxx0000000000000000000\r11100000000000000000000\r11100000000000000000000\r11100000000000000000000\rxxxxx000x11111111x0000x\rxxxxxx00x1111x111x000xx\rxxxxxxx0x11111111x00xxx\rxxxxxxxxx11111111x0xxxx\rxxxxxxxxx11111111xxxxxx\r"
        },
        new()
        {
            Id = "cafe_gold0", Name = "cafe_gold0", DoorX = 9, DoorY = 29, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxx1111xxxxxxx\rxxxxxxxxxx11111xxxxxx\rxxxxxxxxxx111111xxxxx\rxx111111111111111xxxx\rx11111111111111111xxx\r1111111111111111111xx\r11111111111111111111x\r111111111111111111111\r111111111111111111111\r1111111111111x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000x1111111\r1111111000000xxx00000\r111111100000000000000\r111111100000000000000\r111111100000000000000\r111111100000000xxxxx0\r11111110000000xxxxxx0\r11111110000000xxxxxx0\r11111110000000xxxxxxx\rx1111110000000xxxxxxx\rxxxxxxxx0000000000xxx\rxxxxxxxx000xxxxxxxxxx\rxxxxxxxx000xxxxxxxxxx\rxxxxxxxx000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "cafe", Name = "cafe", DoorX = 30, DoorY = 40, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxx00000xx00000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx000000000000000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000000xxx0000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000000xxxx000000xxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx0000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx00000000000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000000xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "den", Name = "den", DoorX = 3, DoorY = 22, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "00000000xxxxxxxx\r0000000000000000\r0000000000000000\r000000000000xx00\r0000000000000000\r0000000000000000\r0000000000000000\rx000000000000000\r0000000000000000\r0000000000000000\r0000000000000000\r0000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rxxx00xxxxxxxxxxx\rxxx00xxxxxxxxxxx\rxxx00xxxxxxxxxxx\r"
        },
        new()
        {
            Id = "gardens", Name = "gardens", DoorX = 2, DoorY = 15, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0xxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00xxxxxxxxxxxx\rxxxxxxxxxxxxx0x00xxxxxxxxxxx0x000xxxxxxxxxxx\rxxxxxxxxxxxx0000000000000000000000xxxxxxxxxx\rxxxxxxxxxxx000000000000000000000000xxxxxxxxx\rxxxxxxxxxxx0000000000000000000000000xxxxxxxx\rxxxxxxxxxxx00000000000000000000000000xxxxxxx\rxxxxxxxx000000000000000000000000000000xxxxxx\rxxxxxxx00000000000000000000000000000000xxxxx\rxxxxxxx000000000000000000000000000000000xxxx\rxxxxxxx0000000000000000000000000000000000xxx\rxxxxxxxxx000000000000000000000000000000000xx\r00000000000000000000xx00000000000000000000xx\r0000000000000000000xxxx00000000000xxxxxxx0xx\r0000000000000000000xxxx00000000000x00000xxxx\rxxxxx00x0000000000xxxxx0xxxxxx0000x0000000xx\rxxxxx0000000000000xxxxx0xx000x0000x000000xxx\rxxxxx0000000000000xxxxx0x000000000x00000xxxx\rxxxxx000000x0000000xxxx0x000000000xxx00xxxxx\rxxxxxxxx000x0000000xxx00xxx000000x0000xxxxxx\rxxxxxxxx000x000000xxxx0x0000000000000xxxxxxx\rxxxxxxxx000x000000011100000000000000xxxxxxxx\rxxxxxxxx000x00000001110000000000000xxxxxxxxx\rxxxxxxxxx00x0000000111x00000000x00xxxxxxxxxx\rxxxxxxxxxx0x0000000xxx0000000xxxxxxxxxxxxxxx\rxxxxxxxxxxxx000000xxxx0000000xxxxxxxxxxxxxxx\rxxxxxxxxxxxx000000xxx00xxxxx00xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxx0xx000x00xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxx0x000000xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxx0x00000xxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxxxx00xxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxx0xxxxx0xxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "gate_park", Name = "gate_park", DoorX = 17, DoorY = 26, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxx222xx222222xxx22xxxxxxx\rxxxxxxxxx222xx2222222xx22xxxxxxx\rxxxxxxxxx22222222222222222xxxxxx\rxxxxxxxxx22222222222222222xxxxxx\rxxxxxxxxx22222222222222222xxxxxx\rxxxxxxxxx22222x22222x22222xxxxxx\rxxxxxxxxx11111x22222x11111xxxxxx\r0000000xx00000x22222x00000xxxxxx\r0000000xx00000000000000000xxxxxx\r000000000000000000000000000xx00x\r000000000000xxx00000xxx00000000x\r000000000000xxx00000xxx00000000x\r000000000000xxx00000xxx000000000\r00000000000000000000000000000000\rx0000000000000000000000000000000\rxxx00000000000000000000000000000\rxxxxx000000000000000000000000000\rxxxxx000000000000000000000000000\rxxxxx000000000000000000000000xxx\rxxxxxx00000000000000000000000xxx\rxxxxxxx000000000000000000000xxxx\rxxxxxxxxxx00000000000000000xxxxx\rxxxxxxxxxx0000000000000000xxxxxx\rxxxxxxxxxx000000000000000xxxxxxx\rxxxxxxxxxxxxx00000000000xxxxxxxx\rxxxxxxxxxxxxxx000000000xxxxxxxxx\rxxxxxxxxxxxxxxxx000xxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx000xxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx000xxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "gate_park_2", Name = "gate_park_2", DoorX = 17, DoorY = 23, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxx111111111111xxxxxxxxxxxx\rxxxxxxxxxx11111111111111xxxxxxxxxxx\rxxxxxxxxxx11111111111111xxxxxxxxxxx\rxxxxxxxxxx11xxxx11xxxx11xxxxxxxxxxx\rxxxxxxxxxx00xxxx00xxxx00xxxxxxxxxxx\rxxxxxxx0000000000000000000xxxxxxxxx\rxxxxxx000000000000000000000xxxxxxxx\rxxxxx0000000000000000000x000xxxxxxx\rxxxx00000000000000000000xx000xxxxxx\rxxxx00000000000000000000xxx000xxxxx\rxxxx00000000000000000000xxxx00xxxxx\r000000000000000000000000000000xxxxx\r0000000000000000000000000000000xxxx\r000000000000000000000000000000xxxxx\r000000000000000000000000000000xxxxx\r000000000000000000000000000000xxxxx\rxx00000000000000000000000000000000x\rxxx000xxxx00000000000000xxxx0000000\rxxx0000xxx00000000000000xxx00000000\rxxxx0000xx00000000000000xx000000000\rxxxxx0000x00000000000000x00000000xx\rxxxxxx00000000000000000000000xxxxxx\rxxxxxxx00000x000000000000000x0xxxxx\rxxxxxxxx0000xxx0000xxx000000xxxxxxx\rxxxxxxxxx000xxx0000xxx000000xxxxxxx\rxxxxxxxxxxxxxxx0000xxx000000xxxxxxx\rxxxxxxxxxxxxxxxx000xxx000000xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxx00000xxxxxxxx\r"
        },
        new()
        {
            Id = "sun_terrace", Name = "sun_terrace", DoorX = 9, DoorY = 17, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxx21000000000xxxxxxxx\rxxxxxx3xxx000xx000xxxxxxx\rxxxxxx4xxx000xxx000xxxxxx\rxxxxxx44xx000x00x000xxxxx\rxxxxxx44xx0000xx00000xxxx\rxxxxxx44xx000000000000xxx\rxxxxxx44xx0000000000000xx\rxxxxxxx4xxxxxxx00000000xx\rxxxxxxx4xxxxxxx0000000xxx\rxxxxxx444432222xxx00xxxxx\rxxxxxx444432222x0000000xx\rxxxxxx444432222x0000000xx\rxxxxxx44400x222x0000000xx\rxxxxxx444000x11x0000000xx\rxxxxxx444000000x0000000xx\rxxxxxx444000000x0000000xx\rxxxxxx440000000000000000x\rxxxxxx4400000000000000000\rx8876x444000000x000000000\rx8xx6x444000000x000000000\rx9xx6x444000000x000000000\r999x65444000000x000000000\r999xxx444xxxxxxxxxx000000\r999xxx444xxxxxxxxxxx00000\r999xxx333xxxxxxxxxxxx0000\r999xxx222222222222222x000\rxxxxxx222222222222222xx00\rxxxxxx222222222222222xxx0\rxxxxxx222222222222222xxxx\rxxxxxxx22222222222222xxxx\rxxxxxxxx2222222222222xxxx\r"
        },
        new()
        {
            Id = "space_cafe", Name = "space_cafe", DoorX = 21, DoorY = 17, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "x3333x333211111xxxxxxxxx\rx3333x333211111xx3333333\rxxxxxx333211111xx3333333\r33333333xx11111xx3333333\r33333333xx11111xx3333333\r33x333xxxx11111xx3333333\rxxx222xxx111111xx3333333\r22222222xx11111xx3333333\r22222222xxx1111xx3333333\r22222222xxxx1111x2222222\r22222222xxxx1111x1111111\r22222222xxxx111111111111\r22222222xxxx111111111111\rxxx222xxxxx1111111111111\rxxxx33xxxx11111111111111\rxxx333321111111111111111\rxxx333321111111111111111\rxxx333321111111111111111\rxxxxxxxxxxxxx1111xxxx11x\rxxxxxxxxxxxxx0000xxxx11x\rxxxxxxxxxx0000000xxxx11x\rxxxxxxxxxx0000000xxxxxxx\rxxxxxxxxxx0000000xxxxxxx\rxxxxxxxxxx0000000xxxxxxx\rxxxxxxxxxx0000000xxxxxxx\rxxxxxxxxxx0000000xxxxxxx\r"
        },
        new()
        {
            Id = "beauty_salon0", Name = "beauty_salon0", DoorX = 4, DoorY = 3, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxx0000000000000xxxxxxxx\rxxx00000000000000xxxxxxx\rxxxxxx000000000000xxxxxx\rxxxxxxxxxxxxx0000xxxxxxx\rxxxx0x0000x00000000xxxxx\rxxx00xxxxxx0000000xxxxxx\rxx000x000xx0000000xxxxxx\rxx000xxxxx00000000xxxxxx\rxx000x000000000000xxxxxx\rxx000x000000000000xxxxxx\rxx00xx000000000000xxxxxx\rxx00xx00x0000000000xxxxx\rxx00xx00x0000000000xxxxx\rxx00xx0000000000000xxxxx\rxx00xx0000000000000xxxxx\rxx000x0xx0000000000xxxxx\rxx000x0x00000000000xxxxx\rxx000x0x00x00000000xxxxx\rxx000x0x00000000000xxxxx\rxx000x0x00x00000000xxxxx\rxx000xx000000000000xxxxx\rxx00000000000000000000xx\rxx00000000000000000000xx\rxxxxxx0000000000000000xx\r"
        },
        new()
        {
            Id = "chill", Name = "chill", DoorX = 22, DoorY = 22, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxx00xxxxxxxx\rxxxxxxxxxxx000000xxxxxxxx\rxxxxxxxxxxx000000xxxxxxxx\rxxxxxxxxxxxxxx000xxxxxxxx\rxxxxxxxxxxxxxxxx0xxxxxxxx\rxxxxxxxxx00000000xxxxxxxx\rxxxxxxxx000000xxxxxxxxxxx\rxxxxxxxx000000xxxxxxxxxxx\rxxxxxxxx000000xxxxxxxxxxx\rxxxxxxxx000000xxxxxxxxxxx\rxxxxxxxx000000xxxxxxxxxxx\rxxxxxxxx0000000xxxxxxxxxx\rxxxxxxxx00000000xxxxxxxxx\rxxxxxxxx0000000000xxxxxxx\rxxxxxxxx0000000000xxxxxxx\rxxxxxxxx0000000000xxxxxxx\rxxxxxxxx0000000000xxxxxxx\rxx000000000000xxxxxxxxxxx\rxx000000000000000000000xx\rxx000000000000000000000xx\rxx000000000xx0000000000xx\rxx000000000xxxxx000000000\rxx000000000xxx0x000000000\rxx00000x000xxx0x000000000\rxx000000000xxxxx0000000xx\rxx000000000000000000000xx\rxx000000000000000000000xx\rxx000000000000000000000xx\rxx000000000000xxxxxxxxxxx\r"
        },
        new()
        {
            Id = "dusty_lounge", Name = "dusty_lounge", DoorX = 14, DoorY = 1, DoorZ = 2, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx22xxxxxxxxxxxxx\rxxxxxxxxxx222x222x2xxxxxxxxxx\rxxxxxxx33322222222223xxxxxxx3\rxxxxxxx33322222222223xxxxxxx3\rxxxxxxx33322222222223x33333x3\rxxxxxxx33322222222223x33333x3\rxx111xx33322222222223xxxxxxx3\rxx111xxx332222222222333333333\rxx111xxxx32222222222333333333\rxx111xxxxxx222222222333333333\rxx111xxxxxxx1111111x333333333\rxx111xxxxxxx1111111x222222222\rxx111xxxxxx111111111111111111\rxx111xxxxxx111111111111111111\r11111xxxxxx111111111111111111\r11111xxxxxx111111111111111111\r11x11xxxxxx111111111111111111\r11xxxxxxxxx11111111111111111x\rx11xxxxxxxxx1111111x1111111xx\rxx11xxxxxxx111111111111111xxx\rxxx11xxxxxx11111111111111xxxx\rxxxx11111111111111111111xxxxx\rxxxxx11111111111111xxxxxxxxxx\rxxxxxxxxxxx11111111xxxxxxxxxx\rxxxxxxxxxxx11111111xxxxxxxxxx\r"
        },
        new()
        {
            Id = "cr_staff", Name = "cr_staff", DoorX = 3, DoorY = 22, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "00000000xxxxxxxx\r0000000000000000\r0000000000000000\r000000000000xx00\r0000000000000000\r0000000000000000\r0000000000000000\rx000000000000000\r0000000000000000\r0000000000000000\r0000000000000000\r0000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rx000000000000000\rxxx00xxxxxxxxxxx\rxxx00xxxxxxxxxxx\rxxx00xxxxxxxxxxx\r"
        },
        new()
        {
            Id = "rooftop", Name = "rooftop", DoorX = 17, DoorY = 12, DoorZ = 4, DoorDirection = 0,
            HeightMap =
                "44xxxxxxxxxxxxxxxxxx\r444xxxxxxxxxxx444444\r4444xxxxxxxxxx444444\r44444xxxx4xxxx444444\r444444xxx44xxx444444\r44444444444444444444\r44444444444444444444\r44444444444444444444\r44444444xx44xx44xx44\r44444444xx44xx44xx44\r44444444444444444444\r44444444444444444444\r44444444444444444444\rx444444x444444xx4444\rx444444x444444xx333x\rx444444x444444xx222x\rx444444x444444xx11xx\rx444444x444444xxxxxx\r"
        },
        new()
        {
            Id = "rooftop_2", Name = "rooftop_2", DoorX = 4, DoorY = 11, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "x0000x000\rxxxxxx000\r000000000\r000000000\r000000000\r000000000\r000000000\r000000000\r000000000\r000000000\rxxx000xxx\rxxx000xxx\r"
        },
        new()
        {
            Id = "tearoom", Name = "tearoom", DoorX = 21, DoorY = 19, DoorZ = 1, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxx3333x33333333x\r333333xx3333x33333333x\r3333333x3333x33333333x\r3333333x3333x33333333x\r3333333xxxxxx33333333x\r333333333333333333333x\r333333333333333333333x\r333333333333333333333x\r333333333333333333333x\r33333333222x333333333x\r33333333222x333333333x\r33333333222x333333333x\r33333333222x333333333x\r33333333111x333333333x\r33333333111x333333333x\r33333333111x333333333x\rxxxxxxxx111xxxxxxxxxxx\r11111111111111111111xx\r1111111111111111111111\r1111111111111111111111\r11111111111111111111xx\r"
        },
        new()
        {
            Id = "cafe_ole", Name = "taivas_cafe", DoorX = 14, DoorY = 29, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXX111111X\rXXXXXXXXXXXXX1111111\rXXXXXXXXXXXXX1111111\rXXXXXXXXXXXXX1111111\rXXXXXXXXXXXXX1111111\rXXX11111111111111111\rXXX11111111111111111\rXX111111111111111111\rXX111111111111111111\rXX111111111111111111\rXXX11111111111111111\r111111111XXXXXXX1111\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\r111111111X0000000000\rX11111111X0000000000\rXX1111111X0000000000\rXXX111111X0000000000\rXXXX11111X0000000000\rXXXXX111110000000000\rXXXXXX11110000000000\rXXXXXXX1110000000000\rXXXXXXXX11000000000X\rXXXXXXXXXX00000000XX\rXXXXXXXXXXXXXX00XXXX\rXXXXXXXXXXXXXX00XXXX\r"
        },
        new()
        {
            Id = "cr_cafe", Name = "cr_cafe", DoorX = 20, DoorY = 10, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "0000000000000000000xx\rx000000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\rxxxx000000000000000xx\r0000000000000000000xx\r0000000000000000000xx\rx000000000000000000xx\rxx00000000000000000xx\rxxxx00000000000000000\rxxx000000000000000000\rxxx0000000000000000xx\rxxx0000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\rxx00000000000000000xx\r"
        },
        new()
        {
            Id = "lobby_a", Name = "lobby_a", DoorX = 12, DoorY = 27, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXX77777777777XXXXX\rXXXXXXXXX777777777777XXXX\rXXXXXXXXX777777777766XXXX\rXXXXXXXXX777777777755XXXX\rXX333333333333333334433XX\rXX333333333333333333333XX\rXX333333333333333333333XX\r33333333333333333333333XX\r333333XXXXXXX3333333333XX\r333333XXXXXXX2222222222XX\r333333XXXXXXX2222222222XX\rXX3333XXXXXXX2222222222XX\rXX3333XXXXXXX222222221111\rXX3333XXXXXXX111111111111\r333333XXXXXXX111111111111\r3333333222211111111111111\r3333333222211111111111111\r3333333222211111111111111\rXX33333222211111111111111\rXX33333222211111111111111\rXX3333322221111111XXXXXXX\rXXXXXXX22221111111XXXXXXX\rXXXXXXX22221111111XXXXXXX\rXXXXXXX22221111111XXXXXXX\rXXXXXXX22221111111XXXXXXX\rXXXXXXX222X1111111XXXXXXX\rXXXXXXX222X1111111XXXXXXX\rXXXXXXXXXXXX11XXXXXXXXXXX\rXXXXXXXXXXXX11XXXXXXXXXXX\rXXXXXXXXXXXX11XXXXXXXXXXX\rXXXXXXXXXXXX11XXXXXXXXXXX\r"
        },
        new()
        {
            Id = "floorlobby_c", Name = "floorlobby_c", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXXXXXX\rXXX0000000000000000XXXXXXX0\rXXX000000000000000000XXXX00\rX00000000000000000000000000\rX00000000000000000000000000\rXXX000000000000000000000000\rXXXXXXX00000000000000000000\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX1XX100000011111111111111\rXXX1XX100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXXXXXXX0000XXXXXXXXXXXXXXX\rXXXXXXXX0000XXXXXXXXXXXXXXX\rXXXXXXXX0000XXXXXXXXXXXXXXX\r"
        },
        new()
        {
            Id = "floorlobby_b", Name = "floorlobby_b", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXXXXXX\rXXX0000000000000000XXXXXXX0\rXXX000000000000000000XXXX00\rX00000000000000000000000000\rX00000000000000000000000000\rXXX000000000000000000000000\rXXXXXXX00000000000000000000\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX1XX100000011111111111111\rXXX1XX100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXXXXXXX0000XXXXXXXXXXXXXXX\rXXXXXXXX0000XXXXXXXXXXXXXXX\rXXXXXXXX0000XXXXXXXXXXXXXXX\r"
        },
        new()
        {
            Id = "floorlobby_a", Name = "floorlobby_a", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "XXXXXXXXXXXXXXXXXXXXXXXXXXX\rXXXXXXXXXXXXXXXXXXXXXXXXXXX\rXXX0000000000000000XXXXXXX0\rXXX000000000000000000XXXX00\rX00000000000000000000000000\rX00000000000000000000000000\rXXX000000000000000000000000\rXXXXXXX00000000000000000000\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX1XX100000011111111111111\rXXX1XX100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXX111100000011111111111111\rXXXXXXXX0000XXXXXXXXXXXXXXX\rXXXXXXXX0000XXXXXXXXXXXXXXX\rXXXXXXXX0000XXXXXXXXXXXXXXX\r"
        },
        new()
        {
            Id = "cinema_a", Name = "cinema_a", DoorX = 20, DoorY = 27, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxxx1xx11111111xxxxxx\rxxx1111111111111111xxxxx\rxxx111xxxx1111111111xxxx\rxxxx2xxxxxxxxxxxxxxxxxxx\rxx3x3x333311xxxxxxxxxx11\rxx3333333311111111111111\rxx3333333311111111111111\rxx3333333311111111122111\rxx3333333311x22222222111\rxx3333333311x22222222111\rxx3333333311xxxxxxxxx111\rxx3333333311111111111111\rxx3333333311111111111111\rxx3333333311111111111111\rxx3333333311111xxxx11111\rxx3333333311111xxxx11111\rxx3333333311111xxxx11111\rxx3333333311111xxxx11111\rxx3333333311111xxxx11111\rxx3333333311111xxxx11111\rxx3333333311111xxxx11111\r333333332111111xxxx11111\r333333332111111111111111\r333333332111111111111111\r333333332111111111111111\rxx3333332111111111111111\rxxxxxxxxxxxxxxxxxxx11111\rxxxxxxxxxxxxxxxxxxx11111\rxxxxxxxxxxxxxxxxxxx11111\r"
        },
        new()
        {
            Id = "sport", Name = "sport", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "111222222222222222x2222\rx11222222222222222x2222\rx11222222222222222x2222\rxx1x2222222222222211111\rx11xx222222222222211111\rx11xx222222x22222211111\rx11xx222222x222222x1111\rx11xx222222x222222x1111\rx11xx2222222222222x1111\rx11xxxxxxxxxxxxxxxx1111\rx1111111111111111111111\rx1111111111111111111111\rx1111111111111111111111\rx1111111111111111111111\rxxxx1111111111111x1111x\r111x1111111111111x1111x\r111x1111111111111x1111x\r111x1111111111111x1111x\r111x11111xxxxxxxxxxxxxx\rx11x1111xxxxxxxxxxxxxxx\rxxxx111xxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "old_skool0", Name = "old_skool0", DoorX = 2, DoorY = 1, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xx0xxxxxxxxxxxxxx\r0000000xxx00000xx\r0000000x0000000xx\r0000000xxxxxxxxxx\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r00000000000000000\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r0000000000000000x\r"
        },
        new()
        {
            Id = "old_skool1", Name = "old_skool1", DoorX = 1, DoorY = 7, DoorZ = 6, DoorDirection = 2,
            HeightMap =
                "x6666666665432100\rx6666666665432100\rx6600000000000x00\rx6600000000000000\rx6600000000000000\rx6600000000000000\rx660000000000x000\r666000000000x1111\rx66000000000xx111\rx66000000000x1111\rx66000000000x1111\rx55000000000x1111\rx44000000000x1111\rx33000000000x1111\rx22000000000xx111\rx11x00000000x1111\rx00000000000x1111\rx00000000000xx111\r"
        },
        new()
        {
            Id = "malja_bar_a", Name = "malja_bar_a", DoorX = 4, DoorY = 24, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxx44\rxxxx444444444444\rxxxx444444444444\rxxxx444444444444\rxxxx444444444444\rxxxx444444444444\rxxxxxxxxxxxxx333\r1111111111111222\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r111111111xxxxxxx\rxxx11111xxxxxxxx\r11111111xxxxxxxx\r11111111xxxxxxxx\r11111111xxxxxxxx\r11111111xxxxxxxx\r"
        },
        new()
        {
            Id = "malja_bar_b", Name = "malja_bar_b", DoorX = 4, DoorY = 24, DoorZ = 3, DoorDirection = 0,
            HeightMap =
                "6666333333333333\r6666333333333333\r6666333333333333\r7766333333333333\r7755333333333333\r8855333333332223\r8844333311111111\r9944333311111111\r9933333311111111\r9933333311111111\r9933333311111111\r9933333311111111\r9933333311111111\r9933333311111111\r9933333211111111\r9933333211111111\r9933333211111111\r9933333311111111\r99333333xxxxxxxx\r99333333xxxxxxxx\rxxx33333xxxxxxxx\rxxx33333xxxxxxxx\r3xx33333xxxxxxxx\rxxx33333xxxxxxxx\rxxx33333xxxxxxxx\rxxx33333xxxxxxxx\r"
        },
        new()
        {
            Id = "bar_a", Name = "bar_a", DoorX = 5, DoorY = 1, DoorZ = 7, DoorDirection = 4,
            HeightMap =
                "xxxx8888xxxxxxxxxxx\rxxxx7777xxxxxxxxxxx\rxxxx6666xxxxxxxxxxx\rxxx6666666555555555\rxxx6666666555555555\rxxx6666666555555555\rxxx6666666555555555\rxxx6666666555555555\rxxx6666666555555555\rxxx6666666555555555\rxxx6666666555xxxxxx\rxxx6666666555555555\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555xxxxxx\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555555555\rxxx5555555555xxxxxx\rxxxx555555555555555\r55xx555555555555555\r55xx555555555555555\r5555555555555555555\r5555555555555555555\rxxxxxxxx55555xxxxxx\rxxxxxxxxx5555xxxxxx\rxxxxxxxxx5555xxxxxx\rxxxxxxxxx5555xxxxxx\rxxxxxxxxx4444xxxxxx\rxxxxxxxxx3333xxxxxx\r"
        },
        new()
        {
            Id = "bar_b", Name = "bar_b", DoorX = 2, DoorY = 12, DoorZ = 4, DoorDirection = 2,
            HeightMap =
                "xxxxx4xxxxxxxxxxxx\rxxxx4444444xxxxxxx\rxxxx4444444xxxxxxx\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\r654444444444444444\r654444444444444444\r654444444444444444\r654444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxx444444444444444\rxxxx44444444444444\rxxxx33444444444444\rxxxx22444444444444\rxxxx2222222222xx44\rxxxx2222222222xx44\rxxxxx222222222xxxx\rxxxxxx22222222xxxx\rxxxxxx22222222xxxx\rxxxxxx22222222xxxx\rxxxxxx22222222xxxx\rxxxxxx22222222xxxx\rxxxxxx22222222xxxx\r"
        },
        new()
        {
            Id = "habburger", Name = "habburger", DoorX = 22, DoorY = 10, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "22222222222222222222xxx\r22222222222222222222xxx\r22222222222222222222xxx\r22222222222222222222xxx\rxxxxxxxxxxxxxxxx1111xxx\rxxxxxxxxxxxxxxxx0000xxx\rxxx00000000000000000xxx\r00000000000000000000xxx\r00000000000000000000xxx\r00000000000000000000000\r00000000000000000000000\r00000000000000000000xxx\r00000000000000000000xxx\r00000000000000000000xxx\rxxx00000000000000000xxx\r"
        },
        new()
        {
            Id = "pizza", Name = "pizza", DoorX = 5, DoorY = 27, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxx0000000\rx11111x1xx000000\r11xxxxx111x00000\r11x1111111xx0000\r11x1111111100000\rxxx1111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r1111111111100000\r11111111111xxxxx\r1111111111xxxxxx\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r1111111111111111\r11xx11xx11111111\rxxxx11xxxxxxxxxx\rxxxx11xxxxxxxxxx\r"
        },
        new()
        {
            Id = "bb_lobby_1", Name = "bb_lobby_1", DoorX = 14, DoorY = 19, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxx2222222222222222x\rxxx2222222222222222x\rxxx2222222222222222x\rxxx2222222222222222x\rxxx11111111111111111\r11x11111111111111111\r11x11111111111111111\r11x11111111111111111\rx1x11111111111111111\rxxx11111111111111111\rxxx11111111111111111\rxxx11111111111111111\rxxx11111111111111111\rxxx11111111111111111\rxxxxxxxxx00000000000\rxxxxxxxxx00000000000\rxxxxxxxxx00000000000\rxxxxxxxxx00000000000\rxxxxxxxxx00000000000\rxxxxxxxxx00000000000\rxxxxxxxxxxxxx000xxxx\rxxxxxxxxxxxxx000xxxx\rxxxxxxxxxxxxx000xxxx\r"
        },
        new()
        {
            Id = "snowwar_lobby_1", Name = "snowwar_lobby_1", DoorX = 41, DoorY = 36, DoorZ = 1,
            DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx11111xx1xxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx11111xx1111xxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxx111111xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxx111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxx1111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxx111111111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxx1111x1111111111xxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "tv_studio", Name = "tv_studio", DoorX = 16, DoorY = 27, DoorZ = 4, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxx\rxxxxx0x00000xxxxxxxx\rxxxxx0x000000xxxxxxx\rxxxxx0x000000xxxxxxx\rxxxxx0x0xxx00000xx0x\rxx0000x000000000xx00\rxx00xxx000000000xx00\rxxxxx00000000000xx00\rx000000000000x000000\rx0000000000000000000\rx0000000000000000x00\r00000000000000000x00\rx000x000000000000x00\rx0000000000000000x00\rx0000000000000000x00\r000x0000000000000000\r000x0000000000000000\r00000000000000xxx000\rx0000000000000000000\rxx00000000000000000x\rxxx000000000000000xx\rxxxxxxxxx1111xxxx0xx\rxxxxxxxxx2222xxxxxxx\rxxxxxxxxx3333xxxxxxx\rxxxxxx44x4444x444xxx\rxxxxx444444444444xxx\rxxxxxx44444444444444\rxxxxx4444x4444444444\rxxxxx4444x4444444444\rxxxxx4444x4444444xxx\rxxxxx444444444444xxx\rxxxxx444444444444xxx\rxxxxxx44444444444xxx\r"
        },
        new()
        {
            Id = "cr_kitchen", Name = "cr_kitchen", DoorX = 7, DoorY = 21, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "X0XXXX000XXXX000X0X\rX000000000000000000\rX000000000000000000\rX000000000000000XXX\rX00XXXX00XXXX000XXX\rX00XXXX00XXXX00XXXX\rX00000000000000XXXX\rX00000000000000XXXX\rX00000000000000XXXX\rX00XXXXXXXXXX00XXXX\rX00XXXXXXXXXX00XXXX\rX00XXXXXXXXXX000XXX\r0000000000000000XXX\r000000000000000XXXX\r000000000000000XXXX\r000XXX0000XXX00XXXX\r000XXX0000XXX00XXXX\r000000000000000XXXX\r000000000000000XXXX\r000000000000000XXXX\rXXXXXXX00XXXXXXXXXX\rXXXXXXX00XXXXXXXXXX\rXXXXXXX00XXXXXXXXXX\r"
        },
        new()
        {
            Id = "club_mammoth", Name = "club_mammoth", DoorX = 6, DoorY = 16, DoorZ = 4, DoorDirection = 2,
            HeightMap =
                "xxxxxx4444444x4444xxxxxxxxxxxxx\rxxxxxx4444444x444322xxxxxxxxxxx\rxxxxxxxxxxxxxx444322xxxxxxxxxxx\rx444444444444444442222xxxxxxxxx\r4444444444444444442222xxxxxxxxx\r4xxxxxxxxxxxxxxxxx2222xxxxxxxxx\r4xxxxxxxxxx22222xx2222xxxxxxxxx\r44xxxxxxxxx22222x2xxxxxxxxxxxxx\rx4444444xxx22222x22xxxxxxxxxxxx\rxx4444444xx22x22x222xxxxxxxxxxx\rxxxxxxx444x22222xxxxxxxxxxxxxxx\rxxxxxx444322222222211111111xxxx\rxxxxxx444322222222211111111xxxx\rxxxxxx444442222222211111111xxxx\rxxx444444442222222211111111xxxx\rxxx444444442222222211111111xxxx\rxxx444444442222222211111111xxxx\rxxx444444442222222211111111xxxx\rxxxxxx4444422222222x1111111xxxx\rxxxxxx4444422222222xxxxxxxxxxxx\rxxxxxx4443222222222222222222xxx\rxxxxxx4443xxxxxxx2xxxxx222xxxxx\rxxxxxx444xxxxxxxxxxxxxxx22xxxxx\rxxxxxx4xxxxxxxxxxxxx444422xxxxx\rxxx4444xxxxxxxxxxxxx4444x2xxxxx\rxxx566666666666666664444xxxxxxx\rxxxx66666666666666664444xxxxxxx\rxxxxxxx666666666666544xxxxxxxxx\rxxxxxxx666666666666544xxxxxxxxx\rxxxxxxx6666666666666xxxxxxxxxxx\rxxxxxxx6666666666666xxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "ice_cafe", Name = "taivas_cafe", DoorX = 17, DoorY = 23, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx1111111000000000\rxx1111111000000000\r111111111000000000\r111111111000000000\r111111111000000000\r111111111000000000\r111111111000000000\r11111111x000000000\r11111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx111111x000000000\rxx1111110000000000\rxx1111111000000000\rxx1111111000000000\rxx1111111000000000\r\r"
        },
        new()
        {
            Id = "netcafe", Name = "netcafe", DoorX = 22, DoorY = 12, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxxx1111xxxxxxxxxxx1xxxx\rxxxxx1111111111111111xxxx\rxxxxx1111111111111111xxxx\rxxxxx1111111111111111xxxx\rxxxxxxxx0000000000000xxxx\r111111100000000000000xxxx\r111111100000000000000xxxx\r111111100000000000000xxxx\rxxxx11100000000000000xxxx\rx1xx11100000000000000xxxx\rx1xx11100000000000000xxxx\rx1xx111000000000000000000\rx1xx111000000000000000000\rxxxx111000000000000000000\rxxxx11100000000000000xxxx\rxxxx1110000000xx11111xxxx\rxxxxx111110000x111111xxxx\rxxxxxx111100001111111xxxx\rxxxxxx111100001111111xxxx\rxxxxxx111100001111111xxxx\rxxxxxx111100001111111xxxx\rxxxxxx111100001111111xxxx\rxxxxxx111100001111111xxxx\rxxxxx1111100001111111xxxx\r\r"
        },
        new()
        {
            Id = "hallway0", Name = "hallway0", DoorX = 2, DoorY = 2, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxx000000001111111111111111xxxx\rxxxx000000001111111111111111xxxx\r00000000000011111111111111111111\r00000000000011111111111111111111\r00000000000011111111111111111111\r00000000000011111111111111111111\rxxxx000000001111111111111111xxxx\rxxxx0000000x1111111111111111xxxx\rxxxxxxxxxxxxx1111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallway9", Name = "hallway9", DoorX = 21, DoorY = 23, DoorZ = 0, DoorDirection = 7,
            HeightMap =
                "xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxx000000000000000000000000xxxx\rxxxx000000000000000000000000xxxx\r00000000000000000000000000000000\r00000000000000000000000000000000\r00000000000000000000000000000000\r00000000000000000000000000000000\rxxxx000000000000000000000000xxxx\rxxxx000000000000000000000000xxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx000000000000xxxxxxxx\rxxxxxxxxxxxx000000000000xxxxxxxx\rxxxxxxxxxxxx000000000000xxxxxxxx\rxxxxxxxxxxxx000000000000xxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallway2", Name = "hallway2", DoorX = 15, DoorY = 2, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx000xxxxxxxxxxx\rxxxxxxxxxxxxxx000xxxxxxxxxxx\rxxxxxxxxxxxxxx000xxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxx\rxxxx11111111000000000000xxxx\rxxxx11111111000000000000xxxx\r1111111111110000000000000000\r1111111111110000000000000000\r1111111111110000000000000000\r1111111111110000000000000000\rxxxx11111111000000000000xxxx\rxxxx11111111000000000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxx11111111xxxx00000000xxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallway1", Name = "hallway1", DoorX = 2, DoorY = 14, DoorZ = 0, DoorDirection = 2,
            HeightMap =
                "xxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0000xxxxxxxxxxxxxx\rxxxxxxxxxxxx0000000000000000xxxx\rxxxxxxxxxxxx0000000000000000xxxx\rxxxxxxxxxxxx00000000000000000000\rxxxxxxxxxxxx00000000000000000000\rxxxxxxxxxxxx00000000000000000000\rxxxxxxxxxxxx00000000000000000000\rxxxxxxxxxxxx0000000000000000xxxx\rxxxxxxxxxxxx0000000000000000xxxx\rxxxx1111111100000000xxxxxxxxxxxx\rxxxx1111111100000000xxxxxxxxxxxx\r11111111111100000000xxxxxxxxxxxx\r11111111111100000000xxxxxxxxxxxx\r11111111111100000000xxxxxxxxxxxx\r11111111111100000000xxxxxxxxxxxx\rxxxx1111111100000000xxxxxxxxxxxx\rxxxx1111111100000000xxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallway3", Name = "hallway3", DoorX = 14, DoorY = 21, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xxxxxx1111xxxxxxxxxxxxxxxxxxxxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxxxxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxxxxxx\rxxxxxx1111xxxxxxxxxxxxxxxxxxxxxx\rxxxx111111111111111100000000xxxx\rxxxx111111111111111100000000xxxx\r11111111111111111111000000000000\r11111111111111111111000000000000\r11111111111111111111000000000000\r11111111111111111111000000000000\rxxxx111111111111111100000000xxxx\rxxxx111111111111111100000000xxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1111xxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallway4", Name = "hallway4", DoorX = 29, DoorY = 3, DoorZ = 1, DoorDirection = 6,
            HeightMap =
                "xxxx000000001111111111111111xxxx\rxxxx000000001111111111111111xxxx\r00000000000011111111111111111111\r00000000000011111111111111111111\r00000000000011111111111111111111\r00000000000011111111111111111111\rxxxx000000001111111111111111xxxx\rxxxx000000001111111111111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxx11111111xxxx\rxxxxxxxxxxxxxxxxxxxxxx1111xxxxxx\rxxxxxxxxxxxxxxxxxxxxxx1111xxxxxx\rxxxxxxxxxxxxxxxxxxxxxx1111xxxxxx\rxxxxxxxxxxxxxxxxxxxxxx1111xxxxxx\r"
        },
        new()
        {
            Id = "hallway5", Name = "hallway5", DoorX = 14, DoorY = 2, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx11xxxxxx1111xx\rxxxxxxxxxxxxxx111xxxxx1111xx\rxxxxxxxxxxxxxx1111xxxx1111xx\rxxxxxxxxxxxxxx1111xxxx1111xx\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxxxxxxxxxx1111111111111111\rxxxx000000001111111111111111\rxxxx000000001111111111111111\r0000000000001111111111111111\r0000000000001111111111111111\r0000000000001111111111111111\r0000000000001111111111111111\rxxxx000000001111111111111111\rxxxx0000000x1111111111111111\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\rxxxxxxxxxxxx11111111xxxxxxxx\r"
        },
        new()
        {
            Id = "hallway8", Name = "hallway8", DoorX = 15, DoorY = 3, DoorZ = 0, DoorDirection = 4,
            HeightMap =
                "xxxxxxxxxxxxxx00xxxx0000\rxxxxxxxxxxxxxx000xxx0000\rxxxxxxxxxxxxxx0000xx0000\rxxxxxxxxxxxxxx0000xx0000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111000000000000\rxxxx11111111xxxx00000000\rxxxx11111111xxxx00000000\r111111111111xxxx00000000\r111111111111xxxx00000000\r111111111111xxxx00000000\r111111111111xxxx00000000\rxxxx11111111xxxx00000000\rxxxx11111111xxxx00000000\rxxxxxxxxxxxxxxxxxx0000xx\rxxxxxxxxxxxxxxxxxx0000xx\rxxxxxxxxxxxxxxxxxx0000xx\rxxxxxxxxxxxxxxxxxx0000xx\r"
        },
        new()
        {
            Id = "hallway7", Name = "hallway7", DoorX = 7, DoorY = 2, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "xxxxxx11xxxxxxxxxxxx\rxxxxxx111xxxxxxxxxxx\rxxxxxx1111xxxxxxxxxx\rxxxxxx1111xxxxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx111111111111xxxx\rxxxx111111111111xxxx\rxxxx111111111111xxxx\rxxxx111111111111xxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx11111111xxxxxxxx\rxxxx000000000000xxxx\rxxxx000000000000xxxx\r00000000000000000000\r00000000000000000000\r00000000000000000000\r00000000000000000000\rxxxx000000000000xxxx\rxxxx000000000000xxxx\r"
        },
        new()
        {
            Id = "hallway6", Name = "hallway6", DoorX = 1, DoorY = 10, DoorZ = 1, DoorDirection = 2,
            HeightMap =
                "xxxx1111111111111111xxxx\rxxxx1111111111111111xxxx\rxxxx1111111111111111xxxx\rxxxx1111111111111111xxxx\rxxxx1111xxxxxxxxxxxxxxxx\rxxxx1111xxxxxxxxxxxxxxxx\rxxxx1111xxxxxxxxxxxxxxxx\rxxxx1111xxxxxxxxxxxxxxxx\rxxxx1111111100000000xxxx\rxxxx1111111100000000xxxx\r111111111111000000000000\r111111111111000000000000\r111111111111000000000000\r111111111111000000000000\rxxxx1111111100000000xxxx\rxxxx1111111100000000xxxx\rxxxxxxxx1111xxxxxxxxxxxx\rxxxxxxxx1111xxxxxxxxxxxx\rxxxxxxxx1111xxxxxxxxxxxx\rxxxxxxxx1111xxxxxxxxxxxx\rxxxxxxxx111111111111xxxx\rxxxxxxxx111111111111xxxx\rxxxxxxxx111111111111xxxx\rxxxxxxxx111111111111xxxx\r"
        },
        new()
        {
            Id = "hallway10", Name = "hallway10", DoorX = 3, DoorY = 23, DoorZ = 1, DoorDirection = 1,
            HeightMap =
                "xxxxxxxxxx00000000xxxx\rxxxxxxxxxx00000000xxxx\rxxxxxxxxxx00000000xxxx\rxxxxxxxxxx00000000xxxx\rxx1111xxxx0000xxxxxxxx\rxx1111xxxx0000xxxxxxxx\rxx1111xxxx0000xxxxxxxx\rxx1111xxxx0000xxxxxxxx\r11111111xx0000000000xx\r11111111xx0000000000xx\r11111111xx0000000000xx\r11111111xx0000000000xx\r11111111xxxxxxxx0000xx\r11111111xxxxxxxx0000xx\r11111111xxxxxxxx0000xx\r11111111xxxxxxxx0000xx\r1111111111111111000000\r1111111111111111000000\r1111111111111111000000\r1111111111111111000000\r1111111111111111000000\r1111111111111111000000\r1111111111111111000000\r1111111111111111000000\rxx1111xxxxxxxxxxxxxxxx\rxx1111xxxxxxxxxxxxxxxx\rxx1111xxxxxxxxxxxxxxxx\rxx1111xxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallway11", Name = "hallway11", DoorX = 20, DoorY = 3, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxx1111111100000000xxxx\rxxxx1111111100000000xxxx\r111111111111000000000000\r111111111111000000000000\r111111111111000000000000\r111111111111000000000000\rxxxx1111111100000000xxxx\rxxxx1111111100000000xxxx\rxxxxxxxxxxxx000000000000\rxxxxxxxxxxxx000000000000\rxxxxxxxxxx00000000000000\rxxxxxxxxxx00000000000000\rxxxxxxxxxx00000000000000\rxxxxxxxxxx00000000000000\rxxxxxxxxxxxx000000000000\rxxxxxxxxxxxx000000000000\rxxxxxxxxxxxx000000000000\rxxxxxxxxxxxx000000000000\rxxxxxxxx000000000000xxxx\rxxxxxxxx000000000000xxxx\rxxxxxxxx000000000000xxxx\rxxxxxxxx000000000000xxxx\r"
        },
        new()
        {
            Id = "star_lounge", Name = "star_lounge", DoorX = 36, DoorY = 35, DoorZ = 0, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx2222x4444442222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222x444x32222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222xx4xx22222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222222222222222111xxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxx22222222222222222111xxxxxxxxx\rxxxxxxxxxxxxxxxx3333x22222222222222xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx3333x22222222222222xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx3333x22222222221111xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx3333xx2x22222220000xxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx333333332222222000000xxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx333333332222222x0000000xxxxxxxxxxx\rxxxxxxxxxxxxxxxxx33333332222222x0000000xxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxx222222000000xxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "orient", Name = "orient", DoorX = 32, DoorY = 20, DoorZ = 1, DoorDirection = 6,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx\rxxxxxxxxxxxxxx1000000000xxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx1xx000x000xx111x111xxx\rxxxxxxxxxxxxxx1xx000x000xxxxxx1111xx\rxxxxxxxxxxxxxx1xx000x000x111111111xx\rxxxxxxxxxxxxxx1xx000x000x111111111xx\rxxx111111111111xx000x000x111111111xx\rxxx1xxxxxxxxxxxxx000x000x111111111xx\rxxx1x1111111111000000000x111111111xx\rxxx1x1111111111000000000xx1111111xxx\rxxx1x11xxxxxx11000000000xx1111111100\rxxx111xxxxxxx11000000000011111111100\rxxx111xxxxxxx11000000000011111111100\rxxxxx1xxxxxxx11000000000011111111100\rxxxxx11xxxxxx11000000000xx1111111100\rxxxxx1111111111000000000xx1111111xxx\rxxxxx1111111111xx000x000x111111111xx\rxxxxxxxxxxxxxxxxx000x000x111111111xx\rxxxxxxxxxxxxxxxxx000x000x111111111xx\rxxxxxxxxxxxxxxxxx000x000x111111111xx\rxxxxxxxxxxxxxxxxx000x000x111111111xx\rxxxxxxxxxxxxxxxxx000x00xx11xxxx111xx\rxxxxxxxxxxxxxxxxxxxxxxxxxx11111111xx\r\r"
        },
        new()
        {
            Id = "entryhall", Name = "entryhall", DoorX = 17, DoorY = 18, DoorZ = 1, DoorDirection = 0,
            HeightMap =
                "xx11xxxx11xxxx11xxxx\rx1111111111111111111\r11111111111111111111\r11111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rx1111111111111111111\rxxxxxxxxxxxxxxxxx11x\r"
        },
        new()
        {
            Id = "hallA", Name = "hallA", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "11xxxxxxxxxxxxxxx\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r"
        },
        new()
        {
            Id = "hallB", Name = "hallB", DoorX = 1, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "x11xxxxxxxxxxxxxxxx\r1111111111111111111\r1111111111111111111\r1111111111111111111\r1111111111111111111\r1111111111111111111\r1111111111111111111\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r111111xxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "hallC", Name = "hallC", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "11xxxxxxxxxxxxxxx\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r"
        },
        new()
        {
            Id = "hallD", Name = "hallD", DoorX = 0, DoorY = 0, DoorZ = 1, DoorDirection = 4,
            HeightMap =
                "11xxxxxxxxxxxxxxx\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r11111111111111111\r"
        },
        new()
        {
            Id = "model_s", Name = "model_s", DoorX = 0, DoorY = 3, DoorZ = 0, DoorDirection = 2,
            HeightMap = "xxxxxxx\rx00000x\rx00000x\r000000x\rx00000x\rx00000x\rx00000x\rx00000x\rxxxxxxx\r"
        },
        new()
        {
            Id = "emperors", Name = "emperors", DoorX = 11, DoorY = 31, DoorZ = 0, DoorDirection = 0,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxx444xxxx4444xxxxxx\rxxxx2x4444xxxx44444x2xxx\rxxxx2x44444x4x44444x2xxx\rxxxx2x4444444444444x2xxx\rxxxx2x33xx33333xx33x2xxx\rxxxx2222xx22222xx2222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22xx222222222xx22xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222222222222222xxx\rxxxx22222xx22x2222222xxx\rxxxxx2xx2xx22xxx2xx2xxxx\rxxxxxxxxxxx11xxxxxxxxxxx\rxxxxxxxxxxx00xxxxxxxxxxx\rxxxxxxxxxxx00xxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\r"
        },
        new()
        {
            Id = "beauty_salon1", Name = "beauty_salon1", DoorX = 14, DoorY = 3, DoorZ = 0, DoorDirection = 1,
            HeightMap =
                "xxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxxxxxxxxxxxx\rxxxxxxxxxxxxxx0xxxxxxxxx\rxxxxxxx000000000000000xx\rxxxxxx0000000000000000xx\rxxxxx000000000000xxxxxxx\rxxxx000000000000000000xx\rxxx0000000000000000000xx\rxxx0000000000000000000xx\rxxx0000000000000000000xx\rxxxxxxxxxxxxxxxx000000xx\rxx0000000000000x000000xx\r000000000000000x000000xx\r000000000000000x000000xx\r000000000000000x000000xx\r00x000000000000x000000xx\r00xxxxxxxxxxxxxx000000xx\r00xxxxxxxxxxxxxx000000xx\r00x0000000000000000000xx\r00x0000000000000000000xx\r00x0000000000000000000xx\r0000000000000000000000xx\rx000000000000000000000xx\rxxx0000000000000000000xx\r"
        }
    };
}