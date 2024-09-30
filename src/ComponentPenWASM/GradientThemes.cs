namespace ComponentPenWASM
{

    public class GradientTheme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LightModeGradient { get; set; }
        public string DarkModeGradient { get; set; }
    }

    public static class GradientThemes
    {
        public static List<GradientTheme> AllThemes = new List<GradientTheme>
{
    new GradientTheme
    {
        Id = 1,
        Title = "Stardust",
        LightModeGradient = "linear-gradient(#090615 0%, #31226D 25%, #6C5AA6 51%, #AE99CB 75%, #E0DEEC 94.5%)",
        DarkModeGradient = "linear-gradient(#E0DEEC 5.5%, #AE99CB 25%, #6C5AA6 49%, #31226D 75%, #090615 100%)"
    },
    new GradientTheme
    {
        Id = 2,
        Title = "Echoes",
        LightModeGradient = "linear-gradient(#101518 3.8%, #1F282E 17.38%, #813928 35.49%, #D44508 49.07%, #E8A38C 76.24%, #DAD8CF 94.35%)",
        DarkModeGradient = "linear-gradient(#DAD8CF 5.65%, #E8A38C 23.76%, #D44508 50.93%, #813928 64.51%, #1F282E 82.62%, #101518 96.2%)"
    },
    new GradientTheme
    {
        Id = 3,
        Title = "Shadows",
        LightModeGradient = "linear-gradient(#1A1A1A 17%, #3B4553 35%, #687B8A 51%, #A3BAC7 79%, #F0F0F0 94.5%)",
        DarkModeGradient = "linear-gradient(#F0F0F0 5.5%, #A3BAC7 21%, #687B8A 49%, #3B4553 65%, #1A1A1A 83%)"
    },
    new GradientTheme
    {
        Id = 4,
        Title = "Phoenix",
        LightModeGradient = "linear-gradient(#2E0D0D 12.5%, #582610 30.5%, #8B4513 45%, #CD853F 59%, #FFDAB9 77%, #EBE5E0 95.5%)",
        DarkModeGradient = "linear-gradient(#EBE5E0 4.5%, #FFDAB9 23%, #CD853F 41%, #8B4513 55%, #582610 69.5%, #2E0D0D 87.5%)"
    },
    new GradientTheme
    {
        Id = 5,
        Title = "Serenity",
        LightModeGradient = "linear-gradient(#060D32 5%, #1D438B 30%, #5A7EC1 50%, #B6D5ED 75%, #FCFCFD 94.5%)",
        DarkModeGradient = "linear-gradient(#FCFCFD 5.5%, #B6D5ED 25%, #5A7EC1 50%, #1D438B 70%, #060D32 95%)"
    },
    new GradientTheme
    {
        Id = 6,
        Title = "Gaia",
        LightModeGradient = "linear-gradient(#1A1A1A 16.94%, #27322B 28.58%, #3B5745 41.36%, #B99741 64.4%, #E8E7E3 89.44%)",
        DarkModeGradient = "linear-gradient(#E8E7E3 10.56%, #B99741 35.6%, #3B5745 58.64%, #27322B 71.42%, #1A1A1A 83.06%)"
    },
    new GradientTheme
    {
        Id = 7,
        Title = "Rhapsody",
        LightModeGradient = "linear-gradient(#FFF8F0 3.8%, #EEFF99 24.62%, #8CDC9E 34.59%, #00A9A5 48.62%, #134074 68.54%, #101518 84.84%)",
        DarkModeGradient = "linear-gradient(#101518 15.16%, #134074 31.46%, #00A9A5 51.38%, #8CDC9E 65.41%, #EEFF99 75.38%, #FFF8F0 96.2%)"
    },
    new GradientTheme
    {
        Id = 8,
        Title = "Resolve",
        LightModeGradient = "linear-gradient(#323742 0%, #9A7E39 25%, #EBAF24 50%, #F3D281 75%, #E1DFDB 100%)",
        DarkModeGradient = "linear-gradient(#E1DFDB 0%, #F3D281 25%, #EBAF24 50%, #9A7E39 75%, #323742 100%)"
    },
    new GradientTheme
    {
        Id = 9,
        Title = "Drifting",
        LightModeGradient = "linear-gradient(#D2CEC2 34.81%, #D2CEC2 50%, #8F9181 56.25%, #6D7163 63.09%, #1B1D1A 74.41%, #727269 80.06%, #B7B6AD 94.35%)",
        DarkModeGradient = "linear-gradient(#B7B6AD 5.65%, #727269 19.94%, #1B1D1A 25.59%, #6D7163 36.91%, #8F9181 43.75%, #D2CEC2 50%, #D2CEC2 65.19%)"
    },
    new GradientTheme
    {
        Id = 10,
        Title = "Twilight",
        LightModeGradient = "linear-gradient(#090E14 17.07%, #102037 33.26%, #2E3E55 43.13%, #9D7E67 59.32%, #F89A30 70.78%, #FE8106 81.83%, #EF5E04 93.29%)",
        DarkModeGradient = "linear-gradient(#EF5E04 6.71%, #FE8106 18.17%, #F89A30 29.22%, #9D7E67 40.68%, #2E3E55 56.87%, #102037 66.74%, #090E14 82.93%)"
    },
    new GradientTheme
    {
        Id = 11,
        Title = "Tranquility",
        LightModeGradient = "linear-gradient(#0E171E 11.61%, #4D6E76 32.55%, #92A6A4 52%, #E2D8BF 72.5%, #D2BC98 94.5%)",
        DarkModeGradient = "linear-gradient(#D2BC98 5.5%, #E2D8BF 27.5%, #92A6A4 48%, #4D6E76 67.45%, #0E171E 88.39%)"
    },
    new GradientTheme
    {
        Id = 12,
        Title = "Dreams",
        LightModeGradient = "linear-gradient(#EEEFF1 5.5%, #C3C0CE 27.5%, #807391 48%, #49394F 67.45%, #1C101E 88.39%)",
        DarkModeGradient = "linear-gradient(#1C101E 11.61%, #49394F 32.55%, #807391 52%, #C3C0CE 72.5%, #EEEFF1 94.5%)"
    },
    new GradientTheme
    {
        Id = 13,
        Title = "Revelation",
        LightModeGradient = "linear-gradient(#171618 10.59%, #31353E 25.26%, #8A6F6B 46.95%, #E2B58E 67.38%, #E8DDCA 89.44%)",
        DarkModeGradient = "linear-gradient(#E8DDCA 10.56%, #E2B58E 32.62%, #8A6F6B 53.05%, #31353E 74.74%, #171618 89.41%)"
    },
    new GradientTheme
    {
        Id = 14,
        Title = "Silence",
        LightModeGradient = "linear-gradient(#FEF0D2 0%, #EDCE9F 22.51%, #BF9058 45.92%, #42291C 73.39%, #161211 90.05%)",
        DarkModeGradient = "linear-gradient(#161211 9.95%, #42291C 26.61%, #BF9058 54.08%, #EDCE9F 77.49%, #FEF0D2 100%)"
    },
    new GradientTheme
    {
        Id = 15,
        Title = "Haven",
        LightModeGradient = "linear-gradient(#DDE3E6 0%, #C1D4DA 24.5%, #9FBFC6 49%, #28626D 70.5%, #09142A 88.39%)",
        DarkModeGradient = "linear-gradient(#09142A 11.61%, #28626D 29.5%, #9FBFC6 51%, #C1D4DA 75.5%, #DDE3E6 100%)"
    },
    new GradientTheme
    {
        Id = 16,
        Title = "Passion",
        LightModeGradient = "linear-gradient(#201920 4.49%, #BB483C 34.83%, #F18456 65.17%, #EDE7C9 95.51%)",
        DarkModeGradient = "linear-gradient(#EDE7C9 4.49%, #F18456 34.83%, #BB483C 65.17%, #201920 95.51%)"
    },
    new GradientTheme
    {
        Id = 17,
        Title = "Resilience",
        LightModeGradient = "linear-gradient(#E8E4E0 20%, #EEBB88 50%, #20392C 100%)",
        DarkModeGradient = "linear-gradient(#20392C 0%, #EEBB88 50%, #E8E4E0 80%)"
    },
    new GradientTheme
    {
        Id = 18,
        Title = "Exploration",
        LightModeGradient = "linear-gradient(#DFD0BB 0%, #E5BD77 22.3%, #CC7951 40.23%, #943D2C 65.44%, #592D29 82.4%, #342124 94.83%)",
        DarkModeGradient = "linear-gradient(#342124 5.17%, #592D29 17.6%, #943D2C 34.56%, #CC7951 59.77%, #E5BD77 77.7%, #DFD0BB 100%)"
    },
    new GradientTheme
    {
        Id = 19,
        Title = "Imagination",
        LightModeGradient = "linear-gradient(#F96E7D 0%, #E5D7BB 33.33%, #E5D7BB 66.67%, #8EB29A 100%)",
        DarkModeGradient = "linear-gradient(#8EB29A 0%, #E5D7BB 33.33%, #E5D7BB 66.67%, #F96E7D 100%)"
    },
    new GradientTheme
    {
        Id = 20,
        Title = "Whispers",
        LightModeGradient = "linear-gradient(#172200 6.25%, #776E0D 25.94%, #DABA0B 50.08%, #E8D67D 66.65%, #E2DAD0 100%)",
        DarkModeGradient = "linear-gradient(#E2DAD0 0%, #E8D67D 33.35%, #DABA0B 49.92%, #776E0D 74.06%, #172200 93.75%)"
    },
    new GradientTheme
    {
        Id = 21,
        Title = "Journey",
        LightModeGradient = "linear-gradient(#0A0F19 8.5%, #123767 27.5%, #1D69C9 49%, #F6A2C6 72%, #ECE7E3 89.5%)",
        DarkModeGradient = "linear-gradient(#ECE7E3 10.5%, #F6A2C6 28%, #1D69C9 51%, #123767 72.5%, #0A0F19 91.5%)"
    },
    new GradientTheme
    {
        Id = 22,
        Title = "Hope",
        LightModeGradient = "linear-gradient(#ECE7E3 10.5%, #F8C74E 28%, #E03C05 52.19%, #7F210A 70%, #0E0908 91.39%)",
        DarkModeGradient = "linear-gradient(#0E0908 8.61%, #7F210A 30%, #E03C05 47.81%, #F8C74E 72%, #ECE7E3 89.5%)"
    },
    new GradientTheme
    {
        Id = 23,
        Title = "Odyssey",
        LightModeGradient = "linear-gradient(#0B0227 8.5%, #1F027F 27.5%, #495AEE 49%, #92AAEC 72%, #DCE2F4 89.94%)",
        DarkModeGradient = "linear-gradient(#DCE2F4 10.06%, #92AAEC 28%, #495AEE 51%, #1F027F 72.5%, #0B0227 91.5%)"
    },
    new GradientTheme
    {
        Id = 24,
        Title = "Eternal",
        LightModeGradient = "linear-gradient(#012015 8.5%, #305949 27.5%, #699B85 49%, #ACB9AF 70%, #DEDDD3 92.33%)",
        DarkModeGradient = "linear-gradient(#DEDDD3 7.67%, #ACB9AF 30%, #699B85 51%, #305949 72.5%, #012015 91.5%)"
    },
new GradientTheme
    {
        Id = 25,
        Title = "Legacy",
        LightModeGradient = "linear-gradient(#A89E8A 9.26%, #C9B282 41.4%, #AD9D85 48.39%, #8C8473 54.95%, #656766 65.25%, #817365 78.52%, #7A6652 94.35%)",
        DarkModeGradient = "linear-gradient(#7A6652 5.65%, #817365 21.48%, #656766 34.75%, #8C8473 45.05%, #AD9D85 51.61%, #C9B282 58.6%, #A89E8A 90.74%)"
    },
    new GradientTheme
    {
        Id = 26,
        Title = "Harmony",
        LightModeGradient = "linear-gradient(#5F7975 0%, #A8A783 33.33%, #CAC6A4 66.67%, #F3E6C6 100%)",
        DarkModeGradient = "linear-gradient(#F3E6C6 0%, #CAC6A4 33.33%, #A8A783 66.67%, #5F7975 100%)"
    },
    new GradientTheme
    {
        Id = 27,
        Title = "Fleeting",
        LightModeGradient = "linear-gradient(#3D0F2F 0%, #8D2B3F 25%, #D6784F 50%, #EEB399 75%, #FDF1EB 100%)",
        DarkModeGradient = "linear-gradient(#FDF1EB 0%, #EEB399 25%, #D6784F 50%, #8D2B3F 75%, #3D0F2F 100%)"
    },
    new GradientTheme
    {
        Id = 28,
        Title = "Introspection",
        LightModeGradient = "linear-gradient(#1C2E42 0%, #495773 25%, #928B9B 50%, #D4B4B7 75%, #F9CFC9 100%)",
        DarkModeGradient = "linear-gradient(#F9CFC9 0%, #D4B4B7 25%, #928B9B 50%, #495773 75%, #1C2E42 100%)"
    },
    new GradientTheme
    {
        Id = 29,
        Title = "Pursuit",
        LightModeGradient = "linear-gradient(#E8F89F 0%, #90C693 33.33%, #15706C 66.67%, #082C2C 100%)",
        DarkModeGradient = "linear-gradient(#082C2C 0%, #15706C 33.33%, #90C693 66.67%, #E8F89F 100%)"
    },
    new GradientTheme
    {
        Id = 30,
        Title = "Solitude",
        LightModeGradient = "linear-gradient(#00030C 0%, #01263B 33.33%, #546672 66.67%, #BEB7AD 100%)",
        DarkModeGradient = "linear-gradient(#BEB7AD 0%, #546672 33.33%, #01263B 66.67%, #00030C 100%)"
    },
    new GradientTheme
    {
        Id = 31,
        Title = "Tenacity",
        LightModeGradient = "linear-gradient(#EDDDD1 0%, #F8CDA6 24.24%, #F79F64 48.47%, #AF6C6A 72.71%, #444A5B 96.94%)",
        DarkModeGradient = "linear-gradient(#444A5B 3.06%, #AF6C6A 27.29%, #F79F64 51.53%, #F8CDA6 75.76%, #EDDDD1 100%)"
    },
    new GradientTheme
    {
        Id = 32,
        Title = "Grief",
        LightModeGradient = "linear-gradient(#F1F1F1 0%, #DBD6D2 24.24%, #AEA59E 48.47%, #937D6C 72.71%, #585858 96.94%)",
        DarkModeGradient = "linear-gradient(#585858 3.06%, #937D6C 27.29%, #AEA59E 51.53%, #DBD6D2 75.76%, #F1F1F1 100%)"
    },
    new GradientTheme
    {
        Id = 33,
        Title = "Cradle",
        LightModeGradient = "linear-gradient(#170211 0%, #2F0405 25%, #351805 50%, #131506 75%, #020B03 100%)",
        DarkModeGradient = "linear-gradient(#020B03 0%, #131506 25%, #351805 50%, #2F0405 75%, #170211 100%)"
    },
    new GradientTheme
    {
        Id = 34,
        Title = "Lust",
        LightModeGradient = "linear-gradient(#492351 0%, #7F376D 20%, #D55882 40%, #FF808A 60%, #FFBF92 80%, #F6E5D9 100%)",
        DarkModeGradient = "linear-gradient(#F6E5D9 0%, #FFBF92 20%, #FF808A 40%, #D55882 60%, #7F376D 80%, #492351 100%)"
    },
    new GradientTheme
    {
        Id = 35,
        Title = "Knowledge",
        LightModeGradient = "linear-gradient(#F3D8E1 4.72%, #919FCC 27.52%, #1969D0 50.32%, #353879 73.12%, #2F0B36 95.93%)",
        DarkModeGradient = "linear-gradient(#2F0B36 4.07%, #353879 26.88%, #1969D0 49.68%, #919FCC 72.48%, #F3D8E1 95.28%)"
    },
    new GradientTheme
    {
        Id = 36,
        Title = "Fortitude",
        LightModeGradient = "linear-gradient(#241C14 0%, #C9731D 30%, #FFDD2B 50%, #83A441 70%, #1C2112 100%)",
        DarkModeGradient = "linear-gradient(#1C2112 0%, #83A441 30%, #FFDD2B 50%, #C9731D 70%, #241C14 100%)"
    },
    new GradientTheme
    {
        Id = 37,
        Title = "Purity",
        LightModeGradient = "linear-gradient(#F3FCE1 0%, #BDF7EF 20%, #B9DCF2 40%, #D6C8EE 79.5%, #F8C6DB 100%)",
        DarkModeGradient = "linear-gradient(#F8C6DB 0%, #D6C8EE 20.5%, #B9DCF2 60%, #BDF7EF 80%, #F3FCE1 100%)"
    },
    new GradientTheme
    {
        Id = 38,
        Title = "Aspiration",
        LightModeGradient = "linear-gradient(#000731 4.72%, #0D5B77 27.52%, #629CB2 50.32%, #D5CAB4 73.12%, #DFB59F 95.93%)",
        DarkModeGradient = "linear-gradient(#DFB59F 4.07%, #D5CAB4 26.88%, #629CB2 49.68%, #0D5B77 72.48%, #000731 95.28%)"
    },
    new GradientTheme
    {
        Id = 39,
        Title = "Freedom",
        LightModeGradient = "linear-gradient(#F5BC4C 0%, #D26A50 24.24%, #894358 48.47%, #2F2D48 72.71%, #0D0F1B 96.94%)",
        DarkModeGradient = "linear-gradient(#0D0F1B 3.06%, #2F2D48 27.29%, #894358 51.53%, #D26A50 75.76%, #F5BC4C 100%)"
    },
    new GradientTheme
    {
        Id = 40,
        Title = "Mindfulness",
        LightModeGradient = "linear-gradient(#13451D 4.72%, #588B3A 27.52%, #9BBD4C 50.32%, #CAE288 73.12%, #F2E8CF 95.93%)",
        DarkModeGradient = "linear-gradient(#F2E8CF 4.07%, #CAE288 26.88%, #9BBD4C 49.68%, #588B3A 72.48%, #13451D 95.28%)"
    },
    new GradientTheme
    {
        Id = 41,
        Title = "Torment",
        LightModeGradient = "linear-gradient(#38454B 0%, #678389 50%, #BFA588 100%)",
        DarkModeGradient = "linear-gradient(#BFA588 0%, #678389 50%, #38454B 100%)"
    },
    new GradientTheme
    {
        Id = 42,
        Title = "Daydream",
        LightModeGradient = "linear-gradient(#BDCFEB 0%, #9CB4D8 19.39%, #BB9FD1 38.78%, #E5A59A 59.62%, #E4BB9B 77.56%, #EBE3DC 96.94%)",
        DarkModeGradient = "linear-gradient(#EBE3DC 3.06%, #E4BB9B 22.44%, #E5A59A 40.38%, #BB9FD1 61.22%, #9CB4D8 80.61%, #BDCFEB 100%)"
    },
    new GradientTheme
    {
        Id = 43,
        Title = "Equilibrium",
        LightModeGradient = "linear-gradient(#01AEBC 0%, #64BFB6 33.33%, #A3CAB9 66.67%, #F5DBC0 100%)",
        DarkModeGradient = "linear-gradient(#F5DBC0 0%, #A3CAB9 33.33%, #64BFB6 66.67%, #01AEBC 100%)"
    },
    new GradientTheme
    {
        Id = 44,
        Title = "Unseen",
        LightModeGradient = "linear-gradient(#E9E3E3 4.4%, #C3BABF 27.2%, #9A8F97 50%, #746A71 72.8%, #50464E 95.6%)",
        DarkModeGradient = "linear-gradient(#50464E 4.4%, #746A71 27.2%, #9A8F97 50%, #C3BABF 72.8%, #E9E3E3 95.6%)"
    },
    new GradientTheme
    {
        Id = 45,
        Title = "Opportunity",
        LightModeGradient = "linear-gradient(#648280 0%, #A9BCBC 25%, #E8E2D3 50%, #EAD8D2 75%, #E8BAAB 100%)",
        DarkModeGradient = "linear-gradient(#E8BAAB 0%, #EAD8D2 25%, #E8E2D3 50%, #A9BCBC 75%, #648280 100%)"
    },
    new GradientTheme
    {
        Id = 46,
        Title = "Rebirth",
        LightModeGradient = "linear-gradient(180deg, #F5EBD6 4.4%, #EDCB9B 18.08%, #EDB850 31.76%, #A544C5 63.68%, #4B17A4 95.6%)",
        DarkModeGradient = "linear-gradient(180deg, #4B17A4 4.4%, #A544C5 36.32%, #EDB850 68.24%, #EDCB9B 81.92%, #F5EBD6 95.6%)"
    },
    new GradientTheme
    {
        Id = 47,
        Title = "Fantasy",
        LightModeGradient = "linear-gradient(180deg, #304571 0%, #2C476C 0.01%, #637AA4 25%, #9CA5C2 50%, #D1C7C8 75%, #EACCCB 100%)",
        DarkModeGradient = "linear-gradient(180deg, #EACCCB 0%, #D1C7C8 25%, #9CA5C2 50%, #637AA4 75%, #2C476C 99.99%, #304571 100%)"
    },
    new GradientTheme
    {
        Id = 48,
        Title = "Shivers",
        LightModeGradient = "linear-gradient(#CFD1D3 4.4%, #B0B6BF 27.2%, #7A869F 50%, #38425C 72.8%, #02091E 95.6%)",
        DarkModeGradient = "linear-gradient(#02091E 4.4%, #38425C 27.2%, #7A869F 50%, #B0B6BF 72.8%, #CFD1D3 95.6%)"
    },
    new GradientTheme
    {
        Id = 49,
        Title = "Quest",
        LightModeGradient = "linear-gradient(#8FE6D7 4.72%, #16CABF 27.52%, #06949D 50.32%, #04596C 73.12%, #0F1A1A 95.93%)",
        DarkModeGradient = "linear-gradient(#0F1A1A 4.07%, #04596C 26.88%, #06949D 49.68%, #16CABF 72.48%, #8FE6D7 95.28%)"
    },
    new GradientTheme
    {
        Id = 50,
        Title = "Prelude",
        LightModeGradient = "linear-gradient(#0D1A26 0%, #231E57 20%, #672D80 40%, #BF549F 60%, #ECB6BC 80%, #F7F2EE 100%)",
        DarkModeGradient = "linear-gradient(#F7F2EE 0%, #ECB6BC 20%, #BF549F 40%, #672D80 60%, #231E57 80%, #0D1A26 100%)"
    }
};


    }




}