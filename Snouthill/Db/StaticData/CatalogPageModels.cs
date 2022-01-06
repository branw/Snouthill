using Snouthill.Db.Models;

namespace Snouthill.Db.StaticData;

public class CatalogPageModels
{
    public static readonly IEnumerable<CatalogPageModel> Models = new List<CatalogPageModel>
    {
        new()
        {
            Id = 1, SortIndex = 1, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Frontpage",
            Name = "Frontpage", Layout = "ctlg_frontpage2", ImageHeadline = "catal_fp_header",
            ImageTeasers = "catal_fp_pic4,catal_fp_pic5",
            Body =
                "Welcome to the Hotel Catalogue. It's packed full of fab things for your room - there's something for everyone! Browse the ranges by clicking the tabs on the right.<br><br>Some ranges are seasonal, so check back regularly for new items.<br><br>We regularly",
            LabelExtraS = "Home sweet home!",
            LabelExtraT =
                "1:You need Credits to buy Furni for your room, click the Purse at the bottom of your screen for more information about Credits."
        },
        new()
        {
            Id = 2, SortIndex = 2, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Rare",
            Name = "Rare", Layout = "ctlg_productpage1", ImageHeadline = "catalog_rares_headline1",
            Body = "Check out these rares!", LabelPick = "None"
        },
        new()
        {
            Id = 3, SortIndex = 3, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Spaces",
            Name = "Spaces", Layout = "ctlg_spaces", ImageHeadline = "catalog_spaces_headline1",
            Body =
                "Floors, wallpapers, landscapes - get a groovy combination to your room. Use our virtual room preview below to test out the combinations before you buy. Select the design and color you like and click Buy.",
            LabelExtraT = "1:Wall\n\n2:Floor\n\n3:Pattern\n\n4:Colour\n\n5:Pattern\n\n6:Colour\n\n7:Preview"
        },
        new()
        {
            Id = 4, SortIndex = 27, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Habbo Exchange", Name = "Habbo Exchange", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_bank_headline1", ImageTeasers = "catalog_bank_teaser",
            Body =
                "The Habbo Exchange is where you can convert your Habbo Credits into a tradable currency. You can use this tradable currency to exchange Habbo Credits for Furni!",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "1:Refundable      goods!"
        },
        new()
        {
            Id = 5, SortIndex = 22, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Rollers",
            Name = "Rollers", Layout = "ctlg_layout2", ImageHeadline = "catalog_roller_headline1",
            Body =
                "Move your imagination, while you move your Habbo!  Perfect for mazes, games, for keeping your queue moving or making your pet go round in circles for hours.  Available in multi-packs ? the more you buy the cheaper the Roller! Pink Rollers out now!",
            LabelPick = "Click on a Roller to see more information!",
            LabelExtraS = "You can fit 30 Rollers in a user flat!"
        },
        new()
        {
            Id = 6, SortIndex = 6, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Teleporters", Name = "Teleporters", Layout = "ctlg_productpage3",
            ImageHeadline = "catalog_doors_headline1",
            ImageTeasers = "catalog_door_a,catalog_door_c,catalog_door_b",
            Body =
                "Beam your user from one room to another with one of our cunningly disguised, space age teleports. Now you can link any two rooms together! Teleports are sold in pairs, so if you trade for them, check you're getting a linked pair.",
            LabelPick = "Click on the item you want for more information", LabelExtraS = "Beam!"
        },
        new()
        {
            Id = 7, SortIndex = 18, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Pets",
            Name = "Pets", Layout = "ctlg_pets", ImageHeadline = "catalog_pet_headline1",
            ImageTeasers = "catalog_pets_teaser1",
            Body =
                "Fluff and whiskers, meows and woofs! You''re about to enter the world of small creatures with furry features. Find a new friend from our ever-changing selection. From faithful servants to playful playmates - here's where you''ll find them all.",
            LabelPick = "Find your own pet!", LabelExtraT = "1:Give name:"
        },
        new()
        {
            Id = 8, SortIndex = 19, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Pet Accessories", Name = "Pet Accessories", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_pet_headline2", ImageTeasers = "ctlg_pet_teaser1",
            Body =
                "You''ll need to take care of your pet to keep it happy and healthy. This section of the Catalogue has EVERYTHING you'll need to satisfy your pet's needs.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2:You'll have to share it!"
        },
        new()
        {
            Id = 9, SortIndex = 6, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Area",
            Name = "Area", Layout = "ctlg_layout2", ImageHeadline = "catalog_area_headline1",
            ImageTeasers = "catalog_area_teaser1",
            Body =
                "Introducing the Area Collection...  Clean, chunky lines set this collection apart as a preserve of the down-to-earth person. It's beautiful in its simplicity, and welcoming to everyone.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: Beautiful in it's simplicity!"
        },
        new()
        {
            Id = 10, SortIndex = 10, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Gothic",
            Name = "Gothic", Layout = "ctlg_layout2", ImageHeadline = "catalog_gothic_headline1",
            ImageTeasers = "catalog_gothic_teaser1",
            Body = "The Gothic section is full of medieval looking items. Create your own Gothic castle!",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 11, SortIndex = 11, MinRole = 1, IndexVisible = false, ClubOnly = false,
            NameIndex = "Soundmachines", Name = "Trax", Layout = "ctlg_soundmachine",
            ImageHeadline = "catalog_djshop_headline1", ImageTeasers = "catalog_djshop_teaser1",
            Body =
                "Bring sound to your room! Purchase a sound machine plus some sample packs and create your own songs to play in your flat!",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 12, SortIndex = 7, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Candy",
            Name = "Candy", Layout = "ctlg_layout2", ImageHeadline = "catalog_candy_headline1",
            ImageTeasers = "catalog_candy_teaser1",
            Body =
                "Candy combines the cool, clean lines of the Mode collection with a softer, more soothing style. It''s urban sharpness with a hint of the feminine.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: Relax! It's faux-fur."
        },
        new()
        {
            Id = 13, SortIndex = 13, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Asian",
            Name = "Asian", Layout = "ctlg_layout2", ImageHeadline = "catalog_asian_headline1",
            ImageTeasers = "catalog_asian_teaser1",
            Body =
                "Introducing the Asian collection... These handcrafted items are the result of years of child slavery, some mixture of Ying and Yang and a mass-shipping from China. These authentic items fit in every oriental themed user flat. Made in China: fo' real nigga",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 14, SortIndex = 9, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Iced",
            Name = "Iced", Layout = "ctlg_layout2", ImageHeadline = "catalog_iced_headline1",
            ImageTeasers = "catalog_iced_teaser1",
            Body =
                "Introducing the Iced Collection...  For the person who needs no introduction. It's so chic, it says everything and nothing. It's a blank canvas, let your imagination to run wild!",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: These chairs are so comfy."
        },
        new()
        {
            Id = 15, SortIndex = 10, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Lodge",
            Name = "Lodge", Layout = "ctlg_layout2", ImageHeadline = "catalog_lodge_headline1",
            ImageTeasers = "catalog_lodge_teaser1",
            Body =
                "Introducing the Lodge Collection...  Do you appreciate the beauty of wood?  For that ski lodge effect, or to match that open fire... Lodge is the Furni of choice for people with that no frills approach to decorating.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: I LOVE this wood Furni!"
        },
        new()
        {
            Id = 16, SortIndex = 12, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Plastic",
            Name = "Plasto", Layout = "ctlg_plasto", ImageHeadline = "catalog_plasto_headline1",
            Body =
                "Introducing The Plasto Collection...  Can you feel that 1970s vibe?  Decorate with Plasto and add some colour to your life. Choose a colour that reflect your mood, or just pick your favourite shade.",
            LabelPick = "Select an item and a colour and buy!", LabelExtraS = "New colors!",
            LabelExtraT = "1:Choose an item\n\n2:Select the color\n\n3:Preview"
        },
        new()
        {
            Id = 17, SortIndex = 13, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Pura",
            Name = "Pura", Layout = "ctlg_layout2", ImageHeadline = "catalog_pura_headline1",
            ImageTeasers = "catalog_pura_teaser1",
            Body =
                "Introducing the Pura Collection...  This collection breathes fresh, clean air and cool tranquillity. Use it to create a special haven away from the hullabaloo of life outside the Hotel.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 18, SortIndex = 11, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Mode",
            Name = "Mode", Layout = "ctlg_layout2", ImageHeadline = "catalog_mode_headline1",
            ImageTeasers = "catalog_mode_teaser1",
            Body =
                "Introducing the Mode Collection...  Steely grey functionality combined with sleek designer upholstery. The person that chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: So shiny and new..."
        },
        new()
        {
            Id = 19, SortIndex = 24, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Accessories", Name = "Accessories", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_extra_headline1", ImageTeasers = "catalog_extra_teaser1",
            Body =
                "Is your room missing something?  Well, now you can add the finishing touches that express your true personality. And don't forget, like everything else, these accessories can be moved about to suit your mood.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: I love my rabbit..."
        },
        new()
        {
            Id = 20, SortIndex = 15, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Bathroom",
            Name = "Bathroom", Layout = "ctlg_layout2", ImageHeadline = "catalog_bath_headline1",
            ImageTeasers = "catalog_bath_teaser1",
            Body =
                "Introducing the Bathroom Collection...  Have some fun with the cheerful bathroom collection. Give yourself and your guests somewhere to freshen up - vital if you want to avoid nasty niffs. Put your loo in a corner though...",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2:  Every Habbo needs one!"
        },
        new()
        {
            Id = 21, SortIndex = 16, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Plants",
            Name = "Plants", Layout = "ctlg_layout2", ImageHeadline = "catalog_plants_headline1",
            ImageTeasers = "catalog_plants_teaser1",
            Body =
                "Introducing the Plant Collection...  Every room needs a plant! Not only do they bring a bit of the outside inside, they also enhance the air quality! Do we give a fuck? Up to you!",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 22, SortIndex = 22, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Sports",
            Name = "Sport", Layout = "ctlg_layout2", ImageHeadline = "catalog_sports_headline1",
            ImageTeasers = "catalog_sports_teaser1",
            Body = "For the sporty people, here is the Sports section! Create your own hockey stadium!",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 23, SortIndex = 17, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Rugs",
            Name = "Rugs", Layout = "ctlg_layout2", ImageHeadline = "catalog_rugs_headline1",
            ImageTeasers = "catalog_rugs_teaser1",
            Body = "We have rugs for all occasions. All rugs are non-slip and washable.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2:We have rugs for ANY room!"
        },
        new()
        {
            Id = 24, SortIndex = 25, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Gallery",
            Name = "Gallery", Layout = "ctlg_layout2", ImageHeadline = "catalog_gallery_headline1",
            ImageTeasers = "catalog_posters_teaser1",
            Body =
                "Adorn your walls with wondrous works of art, posters, plaques and wall hangings. We have items to suit all tastes, from kitsch to cool, traditional to modern.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2: Brighten up your walls!"
        },
        new()
        {
            Id = 25, SortIndex = 26, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Flags",
            Name = "Flags", Layout = "ctlg_layout2", ImageHeadline = "catalog_flags_headline1",
            ImageTeasers = "catalog_flags_teaser1",
            Body =
                "If you're feeling patriotic, get a flag to prove it. Our finest cloth flags will brighten up the dullest walls.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "2:  Flag this     section for later!"
        },
        new()
        {
            Id = 26, SortIndex = 23, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Trophies",
            Name = "Trophies", Layout = "ctlg_trophies", ImageHeadline = "catalog_trophies_headline1",
            Body =
                "Reward your friends, or yourself with one of our fabulous glittering array of bronze, silver and gold trophies.<br><br>First choose the trophy model (click on the arrows to see all the different styles) and then the metal (click on the seal below the trop",
            LabelExtraT = "1:Type your inscription CAREFULLY, it's permanent!"
        },
        new()
        {
            Id = 27, SortIndex = 108, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Club Gifts", Name = "Club Gifts", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_club_headline1", ImageTeasers = "catalog_hc_teaser",
            Body =
                "Welcome to the Club Shop! All 'Habbo Club membership gifts' are available here, use them wisely you greedy cunt! We have sofas, butlers and all the happy stuff.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 28, SortIndex = 110, MinRole = 5, IndexVisible = true, ClubOnly = false, NameIndex = "Dragons",
            Name = "Dragons", Layout = "ctlg_layout2", ImageHeadline = "catalog_rares_headline1",
            Body = "The Dragon page contains all of the Dragon Lamps.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 29, SortIndex = 111, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Sci-fi Doors", Name = "Sci-fi Doors", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 30, SortIndex = 112, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Parasols", Name = "Parasols", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 31, SortIndex = 113, MinRole = 5, IndexVisible = true, ClubOnly = false, NameIndex = "Screens",
            Name = "Screens", Layout = "ctlg_layout2", ImageHeadline = "catalog_rares_headline1",
            Body = "Yet another rares page.", LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 32, SortIndex = 100, MinRole = 5, IndexVisible = true, ClubOnly = false, NameIndex = "Marquee",
            Name = "Marquee", Layout = "ctlg_layout2", ImageHeadline = "catalog_rares_headline1",
            Body = "Yet another rares page.", LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 33, SortIndex = 101, MinRole = 5, IndexVisible = true, ClubOnly = false, NameIndex = "Pillows",
            Name = "Pillows", Layout = "ctlg_layout2", ImageHeadline = "catalog_rares_headline1",
            Body = "Yet another rares page.", LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 34, SortIndex = 102, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Icecream", Name = "Icecream", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 35, SortIndex = 103, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Smoke machines", Name = "Smoke machines", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 36, SortIndex = 104, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Laser Ports", Name = "Laser Ports", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 37, SortIndex = 105, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Amber Lamp", Name = "Amber Lamp", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 38, SortIndex = 106, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Fountains", Name = "Fountains", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 39, SortIndex = 107, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Elephants", Name = "Elephants", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 40, SortIndex = 109, MinRole = 5, IndexVisible = true, ClubOnly = false, NameIndex = "Fans",
            Name = "Fans", Layout = "ctlg_layout2", ImageHeadline = "catalog_rares_headline1",
            Body = "Yet another rares page.", LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 41, SortIndex = 20, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Camera",
            LinkList = "Camera2", Name = "Camera", Layout = "ctlg_camera1",
            ImageHeadline = "catalog_camera_headline1", ImageTeasers = "campic_cam,campic_film",
            Body =
                "With your Camera you can take pictures of just about anything in the hotel - your friend on the loo (hehe), your best dive in the Lido, or your room when you've got it just right!<br><br>A camera costs 10 Credits (two free photos included).",
            LabelExtraT =
                "1:When you've used your free photos, you'll need to buy more. Each roll of film takes five photos. Your Camera will show how much film you have left and loads the next roll automatically.<br><br>Each Film (5 photos) costs:"
        },
        new()
        {
            Id = 42, SortIndex = 21, MinRole = 1, IndexVisible = false, ClubOnly = false, NameIndex = "Camera2",
            Name = "Camera", Layout = "ctlg_camera2", ImageHeadline = "catalog_camera_headline1",
            ImageTeasers = "campic_help",
            Body =
                "CAMERA FUNCTIONS<br><br>1. Press this button to take a photo.<br>2. Photo cancel - for when you've chopped off your friend's head!<br>3. Zoom in and out.<br>4. Photo counter - shows how much film you have left<br>5. Caption Box - write your caption before saving the photo.<br>6. Save - this moves the photo to your giant.<br>You can give photos to your friends, or put them on the wall like posters.",
            LabelPick = "None"
        },
        new()
        {
            Id = 43, SortIndex = 114, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Inflatable Chairs", Name = "Inflatable Chairs", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 44, SortIndex = 115, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Rares Mixed", Name = "Rares Mixed", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another rares page.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 45, SortIndex = 27, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Executive", Name = "Executive", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_exe_headline1", ImageTeasers = "catalog_exe_teaser",
            Body =
                "The Executive Furni is ideal for creating a sophisticated working environment, whether it be an office, a mafia headquarters or study!",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 46, SortIndex = 28, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Alhambra",
            Name = "Alhambra", Layout = "ctlg_layout2", ImageHeadline = "catalog_alh_headline2",
            ImageTeasers = "catalog_alh_teaser2",
            Body =
                "The Palace of Alhambra has appeared and with it this exotic and beautifully crafted range of Arabian Furni. Luxury seating and gourmet food combine to make your room sparkle with riches.",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "s:2:Get your Alhambrian goodies now!"
        },
        new()
        {
            Id = 60, SortIndex = 35, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Habbo Club", LinkList = "Club Info", Name = "Habbo Club", Layout = "ctlg_club1",
            ImageHeadline = "catalog_club_headline1", ImageTeasers = "clubcat_pic",
            LabelExtraT =
                "1:Welcome to Habbo Club - the members only club that all the best Habbos belong to!\n\n2:Every member of Habbo Club gets priority access to the hotel. So, if the hotel's full up, you'll get to the front of the queue automatically - no waiting around! And you'll get exclusive clothes, hair colours, furni, special guest room layouts and more besides. Normal Habbos will not have any of these.\n\n3:How do I join? Use the Navigator to go to 'Hotel View' and click on the Habbo Club icon. Habbo Club costs 20 Credits a month. We'll remind you when your membership is about to run out.\n\n4:Well, what are you waiting for? Join Habbo Club today!"
        },
        new()
        {
            Id = 61, SortIndex = 5, MinRole = 1, IndexVisible = false, ClubOnly = false,
            NameIndex = "Club Info", Name = "Club Info", Layout = "ctlg_club2",
            ImageHeadline = "catalog_club_headline1", ImageTeasers = "club_pos,club_neg",
            LabelExtraT =
                "1:What happens when my Habbo Club runs out?\n\n2:If your Habbo Club runs out, you WILL be able to keep any rooms you made with a Club layout and the Habbo Club Furni is yours to keep.\n\n3:If your Habbo Club runs out you WON'T be able to wander around with a cool HC badge, the funky clothes and your hair will vanish from your Habbo, you won't be able to do chose HC rooms layouts in the Room-O-Matics, you'll receive no new HC Furni and worst all, you won't be able to jump the queue if the Hotel's Full!\n\n4:Stay in Habbo Club for more than a year and you'll get a special sparkly BADGE!"
        },
        new()
        {
            Id = 64, SortIndex = 4, MinRole = 1, IndexVisible = true, ClubOnly = true, NameIndex = "Club Shop",
            Name = "Club Shop", Layout = "ctlg_layout2", ImageHeadline = "catalog_club_headline1",
            ImageTeasers = "catalog_hc_teaser",
            Body =
                "NEW Habbo Club Furni range. Allow these elegant delights to make your room sophisticated and humble. They look great placed with your monthly gifts!",
            LabelPick = "Click on the item you want for more information",
            LabelExtraS = "1:For Habbo Club members only!"
        },
        new()
        {
            Id = 68, SortIndex = 14, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Romantique", Name = "Romantique", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_romantique_headline1", ImageTeasers = "catalog_romantique_teaser1",
            Body =
                "The Romantique range features Grand Pianos, old antique lamps and tables. It is the ideal range for setting a warm and loving mood in your room. Spruce up your room and invite that special someone over. Now featuring the extra special COLOUR edition.",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 81, SortIndex = 8, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Grunge",
            Name = "Grunge", Layout = "ctlg_layout2", ImageHeadline = "catalog_gru_headline1",
            ImageTeasers = "catalog_gru_teaser",
            Body =
                "The Grunge range will get your bedroom looking just the way you like it - organised, neat and tidy!",
            LabelPick = "Click on the item you want for more information"
        },
        new()
        {
            Id = 84, SortIndex = 29, MinRole = 1, IndexVisible = false, ClubOnly = false,
            NameIndex = "How to make music?", Name = "How to make music?", Layout = "ctlg_soundmachine",
            ImageHeadline = "catalog_djshop_headline1", ImageTeasers = "catalog_djshop_teaser1",
            Body =
                "You must own a trax machine and at least one trax pax. Place the trax machine in your room and the trax pax in your hand. Double click the trax machine, click \"Trax editor\" and start editing music. When ready, save, select the tune, turn on the trax machine and enjoy.",
            LabelPick = "Cool, my own music!"
        },
        new()
        {
            Id = 85, SortIndex = 28, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Ambient Trax", Name = "Ambient Trax", Layout = "ctlg_soundmachine",
            ImageHeadline = "catalog_trx_header1", ImageTeasers = "catalog_trx_teaser1",
            Body =
                "Welcome to the Ambient Trax Store! With groovy beats and chilled out melodies, this is the section for some cool and relaxing tunes.",
            LabelExtraT = ""
        },
        new()
        {
            Id = 86, SortIndex = 29, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Dance Trax", Name = "Dance Trax", Layout = "ctlg_soundmachine",
            ImageHeadline = "catalog_trx_header2", ImageTeasers = "catalog_trx_teaser2",
            Body =
                "Welcome to the Dance Trax Store! With funky beats and catchy melodies, this is the section for every clubber  to indulge in.",
            LabelExtraT = ""
        },
        new()
        {
            Id = 87, SortIndex = 30, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Rock Trax", Name = "Rock Trax", Layout = "ctlg_soundmachine",
            ImageHeadline = "catalog_trx_header3", ImageTeasers = "catalog_trx_teaser3",
            Body =
                "Welcome to the Rock Trax Store! With heavy beats and rockin' riffs, this is the section for every rock fan to experiment with.",
            LabelExtraT = ""
        },
        new()
        {
            Id = 88, SortIndex = 31, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "SFX Trax",
            Name = "SFX Trax", Layout = "ctlg_soundmachine", ImageHeadline = "catalog_trx_header4",
            ImageTeasers = "catalog_trx_teaser4",
            Body =
                "Welcome to the SFX Trax Store! With crazy sounds and weird noises, this is the section for every creative room builder  to indulge in.",
            LabelExtraT = ""
        },
        new()
        {
            Id = 89, SortIndex = 32, MinRole = 1, IndexVisible = true, ClubOnly = false,
            NameIndex = "Urban Trax", Name = "Urban Trax", Layout = "ctlg_soundmachine",
            ImageHeadline = "catalog_trx_header5", ImageTeasers = "catalog_trx_teaser5",
            Body =
                "Welcome to the Urban Trax Store! With hip hop beats and RnB vocals, this is the section for every city bopper  to indulge in.",
            LabelExtraT = ""
        },
        new()
        {
            Id = 90, SortIndex = 34, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Presents",
            Name = "Presents", Layout = "ctlg_presents", ImageHeadline = "catalog_gifts_headline1",
            ImageTeasers = "catalog_presents_teaser1,catalog_presents_teaser2",
            Body =
                "Show your Habbo friends just how much you care and send them a gift from the Habbo Catalogue.  ANY Catalogue item can be sent as a gift to ANY Habbo, all you need is their Habbo name!",
            LabelExtraT =
                "1:Buying an item as a gift couldn't be simpler...  <br><br>Buy an item from the Catalogue in the normal way, but tick 'buy as a gift'. Tell us which Habbo you want to give the gift to and we''ll gift wrap it and deliver it straight to their hand."
        },
        new()
        {
            Id = 91, SortIndex = 13, MinRole = 1, IndexVisible = true, ClubOnly = false, NameIndex = "Recycler",
            Name = "Recycler", Layout = "ctlg_recycler", ImageHeadline = "catalog_recycler_headline1"
        },
        new()
        {
            Id = 92, SortIndex = 116, MinRole = 5, IndexVisible = true, ClubOnly = false,
            NameIndex = "Recycler Furni", Name = "Recycler Furni", Layout = "ctlg_layout2",
            ImageHeadline = "catalog_rares_headline1", Body = "Yet another special page.",
            LabelPick = "Click on the item you want for more information"
        }
    };
}