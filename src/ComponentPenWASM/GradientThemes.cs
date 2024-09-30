using System.Collections.Generic;

namespace ComponentPenWASM
{
    public class ColorPalette
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Dictionary<string, string> Colors { get; set; }
    }

    public class GradientTheme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LightModeGradient { get; set; }
        public string DarkModeGradient { get; set; }
        public ColorPalette Palette { get; set; }
    }

    public static class GradientThemes
    {
        public static List<GradientTheme> AllThemes = new List<GradientTheme>();
        public static List<ColorPalette> AllPalettes = new List<ColorPalette>
        {
            new ColorPalette
            {
                Id = 1,
                Title = "Stardust",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#090615" },
                    { "color2", "#31226D" },
                    { "color3", "#6C5AA6" },
                    { "color4", "#AE99CB" },
                    { "color5", "#E0DEEC" }
                }
            },
            new ColorPalette
            {
                Id = 2,
                Title = "Echoes",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#101518" },
                    { "color2", "#1F282E" },
                    { "color3", "#813928" },
                    { "color4", "#D44508" },
                    { "color5", "#E8A38C" },
                    { "color6", "#DAD8CF" }
                }
            },
            new ColorPalette
            {
                Id = 3,
                Title = "Shadows",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#1A1A1A" },
                    { "color2", "#3B4553" },
                    { "color3", "#687B8A" },
                    { "color4", "#A3BAC7" },
                    { "color5", "#F0F0F0" }
                }
            },
            new ColorPalette
            {
                Id = 4,
                Title = "Phoenix",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#2E0D0D" },
                    { "color2", "#582610" },
                    { "color3", "#8B4513" },
                    { "color4", "#CD853F" },
                    { "color5", "#FFDAB9" },
                    { "color6", "#EBE5E0" }
                }
            },
            new ColorPalette
            {
                Id = 5,
                Title = "Serenity",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#060D32" },
                    { "color2", "#1D438B" },
                    { "color3", "#5A7EC1" },
                    { "color4", "#B6D5ED" },
                    { "color5", "#FCFCFD" }
                }
            },
            new ColorPalette
            {
                Id = 6,
                Title = "Gaia",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#1A1A1A" },
                    { "color2", "#27322B" },
                    { "color3", "#3B5745" },
                    { "color4", "#B99741" },
                    { "color5", "#E8E7E3" }
                }
            },
            new ColorPalette
            {
                Id = 7,
                Title = "Rhapsody",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#FFF8F0" },
                    { "color2", "#EEFF99" },
                    { "color3", "#8CDC9E" },
                    { "color4", "#00A9A5" },
                    { "color5", "#134074" },
                    { "color6", "#101518" }
                }
            },
            new ColorPalette
            {
                Id = 8,
                Title = "Resolve",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#323742" },
                    { "color2", "#9A7E39" },
                    { "color3", "#EBAF24" },
                    { "color4", "#F3D281" },
                    { "color5", "#E1DFDB" }
                }
            },
            new ColorPalette
            {
                Id = 9,
                Title = "Drifting",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#D2CEC2" },
                    { "color2", "#8F9181" },
                    { "color3", "#6D7163" },
                    { "color4", "#1B1D1A" },
                    { "color5", "#727269" },
                    { "color6", "#B7B6AD" }
                }
            },
            new ColorPalette
            {
                Id = 10,
                Title = "Twilight",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#090E14" },
                    { "color2", "#102037" },
                    { "color3", "#2E3E55" },
                    { "color4", "#9D7E67" },
                    { "color5", "#F89A30" },
                    { "color6", "#FE8106" },
                    { "color7", "#EF5E04" }
                }
            },
            new ColorPalette
            {
                Id = 11,
                Title = "Tranquility",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#0E171E" },
                    { "color2", "#4D6E76" },
                    { "color3", "#92A6A4" },
                    { "color4", "#E2D8BF" },
                    { "color5", "#D2BC98" }
                }
            },
            new ColorPalette
            {
                Id = 12,
                Title = "Dreams",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#EEEFF1" },
                    { "color2", "#C3C0CE" },
                    { "color3", "#807391" },
                    { "color4", "#49394F" },
                    { "color5", "#1C101E" }
                }
            },
            new ColorPalette
            {
                Id = 13,
                Title = "Revelation",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#171618" },
                    { "color2", "#31353E" },
                    { "color3", "#8A6F6B" },
                    { "color4", "#E2B58E" },
                    { "color5", "#E8DDCA" }
                }
            },
            new ColorPalette
            {
                Id = 14,
                Title = "Silence",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#FEF0D2" },
                    { "color2", "#EDCE9F" },
                    { "color3", "#BF9058" },
                    { "color4", "#42291C" },
                    { "color5", "#161211" }
                }
            },
            new ColorPalette
            {
                Id = 15,
                Title = "Haven",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#DDE3E6" },
                    { "color2", "#C1D4DA" },
                    { "color3", "#9FBFC6" },
                    { "color4", "#28626D" },
                    { "color5", "#09142A" }
                }
            },
            new ColorPalette
            {
                Id = 16,
                Title = "Passion",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#201920" },
                    { "color2", "#BB483C" },
                    { "color3", "#F18456" },
                    { "color4", "#EDE7C9" }
                }
            },
            new ColorPalette
            {
                Id = 17,
                Title = "Resilience",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#E8E4E0" },
                    { "color2", "#EEBB88" },
                    { "color3", "#20392C" }
                }
            },
            new ColorPalette
            {
                Id = 18,
                Title = "Exploration",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#DFD0BB" },
                    { "color2", "#E5BD77" },
                    { "color3", "#CC7951" },
                    { "color4", "#943D2C" },
                    { "color5", "#592D29" },
                    { "color6", "#342124" }
                }
            },
            new ColorPalette
            {
                Id = 19,
                Title = "Imagination",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#F96E7D" },
                    { "color2", "#E5D7BB" },
                    { "color3", "#8EB29A" }
                }
            },
            new ColorPalette
            {
                Id = 20,
                Title = "Whispers",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#172200" },
                    { "color2", "#776E0D" },
                    { "color3", "#DABA0B" },
                    { "color4", "#E8D67D" },
                    { "color5", "#E2DAD0" }
                }
            },
            new ColorPalette
            {
                Id = 21,
                Title = "Journey",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#0A0F19" },
                    { "color2", "#123767" },
                    { "color3", "#1D69C9" },
                    { "color4", "#F6A2C6" },
                    { "color5", "#ECE7E3" }
                }
            },
            new ColorPalette
            {
                Id = 22,
                Title = "Hope",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#ECE7E3" },
                    { "color2", "#F8C74E" },
                    { "color3", "#E03C05" },
                    { "color4", "#7F210A" },
                    { "color5", "#0E0908" }
                }
            },
            new ColorPalette
            {
                Id = 23,
                Title = "Odyssey",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#0B0227" },
                    { "color2", "#1F027F" },
                    { "color3", "#495AEE" },
                    { "color4", "#92AAEC" },
                    { "color5", "#DCE2F4" }
                }
            },
            new ColorPalette
            {
                Id = 24,
                Title = "Eternal",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#012015" },
                    { "color2", "#305949" },
                    { "color3", "#699B85" },
                    { "color4", "#ACB9AF" },
                    { "color5", "#DEDDD3" }
                }
            },
            new ColorPalette
            {
                Id = 25,
                Title = "Legacy",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#A89E8A" },
                    { "color2", "#C9B282" },
                    { "color3", "#AD9D85" },
                    { "color4", "#8C8473" },
                    { "color5", "#656766" },
                    { "color6", "#817365" },
                    { "color7", "#7A6652" }
                }
            },
            new ColorPalette
            {
                Id = 26,
                Title = "Harmony",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#5F7975" },
                    { "color2", "#A8A783" },
                    { "color3", "#CAC6A4" },
                    { "color4", "#F3E6C6" }
                }
            },
            new ColorPalette
            {
                Id = 27,
                Title = "Fleeting",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#3D0F2F" },
                    { "color2", "#8D2B3F" },
                    { "color3", "#D6784F" },
                    { "color4", "#EEB399" },
                    { "color5", "#FDF1EB" }
                }
            },
            new ColorPalette
            {
                Id = 28,
                Title = "Introspection",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#1C2E42" },
                    { "color2", "#495773" },
                    { "color3", "#928B9B" },
                    { "color4", "#D4B4B7" },
                    { "color5", "#F9CFC9" }
                }
            },
            new ColorPalette
            {
                Id = 29,
                Title = "Pursuit",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#E8F89F" },
                    { "color2", "#90C693" },
                    { "color3", "#15706C" },
                    { "color4", "#082C2C" }
                }
            },
            new ColorPalette
            {
                Id = 30,
                Title = "Solitude",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#00030C" },
                    { "color2", "#01263B" },
                    { "color3", "#546672" },
                    { "color4", "#BEB7AD" }
                }
            },
            new ColorPalette
            {
                Id = 31,
                Title = "Tenacity",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#EDDDD1" },
                    { "color2", "#F8CDA6" },
                    { "color3", "#F79F64" },
                    { "color4", "#AF6C6A" },
                    { "color5", "#444A5B" }
                }
            },
            new ColorPalette
            {
                Id = 32,
                Title = "Grief",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#F1F1F1" },
                    { "color2", "#DBD6D2" },
                    { "color3", "#AEA59E" },
                    { "color4", "#937D6C" },
                    { "color5", "#585858" }
                }
            },
            new ColorPalette
            {
                Id = 33,
                Title = "Cradle",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#170211" },
                    { "color2", "#2F0405" },
                    { "color3", "#351805" },
                    { "color4", "#131506" },
                    { "color5", "#020B03" }
                }
            },
            new ColorPalette
            {
                Id = 34,
                Title = "Lust",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#492351" },
                    { "color2", "#7F376D" },
                    { "color3", "#D55882" },
                    { "color4", "#FF808A" },
                    { "color5", "#FFBF92" },
                    { "color6", "#F6E5D9" }
                }
            },
            new ColorPalette
            {
                Id = 35,
                Title = "Knowledge",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#F3D8E1" },
                    { "color2", "#919FCC" },
                    { "color3", "#1969D0" },
                    { "color4", "#353879" },
                    { "color5", "#2F0B36" }
                }
            },
            new ColorPalette
            {
                Id = 36,
                Title = "Fortitude",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#241C14" },
                    { "color2", "#C9731D" },
                    { "color3", "#FFDD2B" },
                    { "color4", "#83A441" },
                    { "color5", "#1C2112" }
                }
            },
            new ColorPalette
            {
                Id = 37,
                Title = "Purity",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#F3FCE1" },
                    { "color2", "#BDF7EF" },
                    { "color3", "#B9DCF2" },
                    { "color4", "#D6C8EE" },
                    { "color5", "#F8C6DB" }
                }
            },
            new ColorPalette
            {
                Id = 38,
                Title = "Aspiration",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#000731" },
                    { "color2", "#0D5B77" },
                    { "color3", "#629CB2" },
                    { "color4", "#D5CAB4" },
                    { "color5", "#DFB59F" }
                }
            },
            new ColorPalette
            {
                Id = 39,
                Title = "Freedom",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#F5BC4C" },
                    { "color2", "#D26A50" },
                    { "color3", "#894358" },
                    { "color4", "#2F2D48" },
                    { "color5", "#0D0F1B" }
                }
            },
            new ColorPalette
            {
                Id = 40,
                Title = "Mindfulness",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#13451D" },
                    { "color2", "#588B3A" },
                    { "color3", "#9BBD4C" },
                    { "color4", "#CAE288" },
                    { "color5", "#F2E8CF" }
                }
            },
            new ColorPalette
            {
                Id = 41,
                Title = "Torment",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#38454B" },
                    { "color2", "#678389" },
                    { "color3", "#BFA588" }
                }
            },
            new ColorPalette
            {
                Id = 42,
                Title = "Daydream",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#BDCFEB" },
                    { "color2", "#9CB4D8" },
                    { "color3", "#BB9FD1" },
                    { "color4", "#E5A59A" },
                    { "color5", "#E4BB9B" },
                    { "color6", "#EBE3DC" }
                }
            },
            new ColorPalette
            {
                Id = 43,
                Title = "Equilibrium",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#01AEBC" },
                    { "color2", "#64BFB6" },
                    { "color3", "#A3CAB9" },
                    { "color4", "#F5DBC0" }
                }
            },
            new ColorPalette
            {
                Id = 44,
                Title = "Unseen",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#E9E3E3" },
                    { "color2", "#C3BABF" },
                    { "color3", "#9A8F97" },
                    { "color4", "#746A71" },
                    { "color5", "#50464E" }
                }
            },
            new ColorPalette
            {
                Id = 45,
                Title = "Opportunity",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#648280" },
                    { "color2", "#A9BCBC" },
                    { "color3", "#E8E2D3" },
                    { "color4", "#EAD8D2" },
                    { "color5", "#E8BAAB" }
                }
            },
            new ColorPalette
            {
                Id = 46,
                Title = "Rebirth",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#F5EBD6" },
                    { "color2", "#EDCB9B" },
                    { "color3", "#EDB850" },
                    { "color4", "#A544C5" },
                    { "color5", "#4B17A4" }
                }
            },
            new ColorPalette
            {
                Id = 47,
                Title = "Fantasy",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#304571" },
                    { "color2", "#2C476C" },
                    { "color3", "#637AA4" },
                    { "color4", "#9CA5C2" },
                    { "color5", "#D1C7C8" },
                    { "color6", "#EACCCB" }
                }
            },
            new ColorPalette
            {
                Id = 48,
                Title = "Shivers",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#CFD1D3" },
                    { "color2", "#B0B6BF" },
                    { "color3", "#7A869F" },
                    { "color4", "#38425C" },
                    { "color5", "#02091E" }
                }
            },
            new ColorPalette
            {
                Id = 49,
                Title = "Quest",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#8FE6D7" },
                    { "color2", "#16CABF" },
                    { "color3", "#06949D" },
                    { "color4", "#04596C" },
                    { "color5", "#0F1A1A" }
                }
            },
            new ColorPalette
            {
                Id = 50,
                Title = "Prelude",
                Colors = new Dictionary<string, string>
                {
                    { "color1", "#0D1A26" },
                    { "color2", "#231E57" },
                    { "color3", "#672D80" },
                    { "color4", "#BF549F" },
                    { "color5", "#ECB6BC" },
                    { "color6", "#F7F2EE" }
                }
            }
        };
        static GradientThemes()
        {
            foreach (var palette in AllPalettes)
            {
                var lightGradient = GenerateGradient(palette.Colors, false);
                var darkGradient = GenerateGradient(palette.Colors, true);

                AllThemes.Add(new GradientTheme
                {
                    Id = palette.Id,
                    Title = palette.Title,
                    LightModeGradient = lightGradient,
                    DarkModeGradient = darkGradient,
                    Palette = palette
                });
            }
        }

        private static string GenerateGradient(Dictionary<string, string> colors, bool isDarkMode)
        {
            var colorList = new List<string>(colors.Values);
            if (isDarkMode)
            {
                colorList.Reverse();
            }

            var gradientStops = new List<string>();
            for (int i = 0; i < colorList.Count; i++)
            {
                var percentage = (100.0 / (colorList.Count - 1)) * i;
                gradientStops.Add($"{colorList[i]} {percentage:F2}%");
            }

            return $"linear-gradient({string.Join(", ", gradientStops)})";
        }
    }
}