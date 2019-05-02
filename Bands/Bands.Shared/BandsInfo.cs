using System;
using System.Collections.Generic;
using System.Text;

namespace Bands
{
    public class BandsInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string backg { get; set; }
      
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string name3 { get; set; }
        public string name4 { get; set; }
        public string name5 { get; set; }
        public string name6 { get; set; }
        public string name7 { get; set; }
        public string name8 { get; set; }
        public string name9 { get; set; }
        public string name10 { get; set; }
        public string id1 { get; set; }
        public string id2 { get; set; }
        public string id3 { get; set; }
        public string id4 { get; set; }
        public string id5 { get; set; }
        public string id6 { get; set; }
        public string id7 { get; set; }
        public string id8 { get; set; }
        public string id9 { get; set; }
        public string id10 { get; set; }
        public string w1 { get; set; }
        public string w2 { get; set; }
        public string w3 { get; set; }
    }
    public class Data
    {
        public List<BandsInfo> Bandsdata { get; set; }

        public void Data_in()
        {
            Bandsdata = new List<BandsInfo>();
            Bandsdata.Add(new BandsInfo() { ID = 0, Name = "Sharmoofers", Image = "Assets/Shar.png", backg = "Assets/sharbg.png",  name1 = "5msa Santi", name2 = "Bartman", name3 = "El Cirque", name4 = "El Boxer-Live", name10 = "Mickey", name9 = "Kawkb", name8 = "Slamo 3likom", name5 = "Sharmoofet", name6 = "El Medly", name7 = "Ma Fi Kalam", id1 = "89711707", id2 = "xi9cg8m92ytl", id3 = "122439845", id4 = "31285825", id5 = "97794568", id6 = "103623964", id7 = "44525752", id8 = "44526007", id9 = "57834074", id10 = "2348158", w1 = "UCNMUETJLeayRYJ4JAQKet6w", w2 = "PLGPF0Whm_rtA0y0n3Fb0ncrJ8YNmR5c7u", w3 = "J9TWq0L26C0" });
            Bandsdata.Add(new BandsInfo() { ID = 1, Name = "Cairokee", Image = "Assets/cairokee.png", backg = "Assets/bgcairo.png", name1 = "EL Baka Baka", name2 = "Qabl El Wosool", name3 = "Marboot Be Astek", name4 = "Nas w Nas", name5 = "Ghammad Einak", name6 = "A'la El Hamesh", name7 = "Kol haga Beta'ady", name8 = "Geina El Dony", name9 = "Wallah Ma Aayez", name10 = "Nefsy Afaggar", id1 = "198420230", id2 = "198420273", id3 = "198420244", id4 = "198420198", id5 = "198420238", id6 = "198420221", id7 = "198420265", id8 = "198420268", id9 = "198420279", id10 = "198420251", w1 = "UCp-brkrLhdNTkAVoR1qHm3A", w2 = "PL8n3QglmB3ieh-HWjVz6El6nipTBD7QbQ", w3 = "-Q9w1Hvv58I" });
            Bandsdata.Add(new BandsInfo() { ID = 2, Name = "10 Gharby", Image = "Assets/10ghar.png", backg = "Assets/10.png", name1 = "Darer El-Basar", name2 = "Pianola", name3 = "Tarakt El-Bashar", name4 = "El-Malal", name5 = "El-Bahar", name6 = "Hekayat", name7 = "feha ser", name8 = "El Fla7a", name9 = "El Resala", name10 = "Ersmni", id1 = "pj3h9z4cnxfo", id2 = "131339357", id3 = "55303759", id4 = "86292547", id5 = "86292962", id6 = "55437197", id7 = "74105163", id8 = "86292200", id9 = "129625476", id10 = "86297967", w1 = "UCz88wqz97SauF8fnaFAIAYQ", w2 = "FLz88wqz97SauF8fnaFAIAYQ", w3 = "Ad-NYl122oE" });
            Bandsdata.Add(new BandsInfo() { ID = 3, Name = "Black Theama", Image = "Assets/bth.png", backg = "Assets/black.png", name1 = "Koun Saied", name2 = "Leh kda", name3 = "Set El Hosn", name4 = "Kol Mara", name5 = "Ala shut el Neel", name6 = "Omaret El Nas", name7 = "Akhbar Ahram Gmhoria", name8 = "Ousso Ousso", name9 = "Kebert", name10 = "Ghawy Bany Adameen", id1 = "202283333", id2 = "211965900", id3 = "165117885", id4 = "48918754", id5 = "202282439", id6 = "202281332", id7 = "202279088", id8 = "202277167", id9 = "202272566", id10 = "202284211", w1 = "UCHag0W1uqNd3Xl0wnatGDuw", w2 = "PLkfh3PzicfHeNCSSPlsix2uBsSAVFv1Ue", w3 = "gXd3B5qAEO0" });
            Bandsdata.Add(new BandsInfo() { ID = 4, Name = "Krakeb", Image = "Assets/krakeb.png", backg = "Assets/kar.png", name1 = "Om El-Shaheed", name2 = "el sheda teslam", name3 = "Faker", name4 = "Peace of Mind", name5 = "7d Masry", name6 = "Kersh kber", name7 = "Thawra Tany", name8 = "A7lamy", name9 = "Sab3 El elil", name10 = "Betzaydo Leh", id1 = "31363216", id2 = "180020311", id3 = "2074837", id4 = "135879358", id5 = "106832851", id6 = "106342494", id7 = "78028586", id8 = "179075142", id9 = "115648416", id10 = "71826438", w1 = "UC_myQxCuxTN3utfc5ovMALA",  w3 = "ox9SK0xDb2U" });
            Bandsdata.Add(new BandsInfo() { ID = 5, Name = "Massar Egbari", Image = "Assets/massar.png", backg = "Assets/msa.png", name1 = "Toaa We Teoam", name2 = "Sabahek", name3 = "Zayek Ana", name4 = "Batooly", name5 = "Awaat", name6 = "Ya Am", name7 = "Ennak Teter", name8 = "Albk Enwany", name9 = "Lesa El Donia", name10 = "Tyib Ya Sbr", id1 = "194602712", id2 = "164088220", id3 = "190995597", id4 = "120083901", id5 = "191005309", id6 = "191004493", id7 = "134206581", id8 = "191004977", id9 = "191005422", id10 = "165328085", w1 = "UC8HZkGE8OJBy3OMlGtoQBGg", w2 = "PLkk6S1qAceWcy_ndTyPOlnYzLcquAtoVU", w3 = "e5-pBqzIPPs" });
            Bandsdata.Add(new BandsInfo() { ID = 6, Name = "Re7la Band", Image = "Assets/re7la.png", backg = "Assets/re7laaaa.png", name1 = "Allah Ya Bdwy", name2 = "Mosiqa Rehla", name3 = "Mosiqa Hala", name4 = "Abd El Wadod", name5 = "Someone like you", name6 = "Koktel-Asmhan", name7 = "Ashky le Men", name8 = "M3l2 Ro7k", name9 = "Hatgn", name10 = "Nor Al nwam", id1 = "94122566", id2 = "134675462", id3 = "178869238", id4 = "134400567", id5 = "1989659", id6 = "145965169", id7 = "131365375", id8 = "95867198", id9 = "134669811", id10 = "134305397", w1 = "UC_y8xnnr9LUAQQ39nvIt-SQ", w3 = "byh2euW5yt4" });
            Bandsdata.Add(new BandsInfo() { ID = 7, Name = "Uss we Laz2", Image = "Assets/uss.png", backg = "Assets/asss.png", name1 = "Lw kont", name2 = "7elmt Teer", name3 = "Gwaia She2", name4 = "Ana 3rby", name5 = "Dya3ty 3omrek", name6 = "Gowak Mgnon", name7 = "Ana El Saye3", name8 = "Bara", name9 = "El Fann", name10 = "Eskendria", id1 = "103770221", id2 = "67455985", id3 = "111730898", id4 = "73414265", id5 = "73403446", id6 = "36581900", id7 = "73398179", id8 = "146421422", id9 = "146421412", id10 = "36582719", w1 = "UCwXKrgvc9NhpOPPXhWSgmHw", w2 = "LLwXKrgvc9NhpOPPXhWSgmHw", w3 = "TfeqUroLX6Y" });
            Bandsdata.Add(new BandsInfo() { ID = 8, Name = "Wasla Band", Image = "Assets/wasla.png", backg = "Assets/was.png", name1 = "El Salam", name2 = "Ayam we Bt3dy", name3 = "Mi3rfsh Skot", name4 = "Msh Ndman", name5 = "3ysheen", name6 = "30 Sana", name7 = "Ana Hor", name8 = "Kareem ya Rab", name9 = "Euro-Arab", name10 = "Ana Msh Ndman", id1 = "187784940", id2 = "187791348", id3 = "98999239", id4 = "189574553", id5 = "187765356", id6 = "187764691", id7 = "187782316", id8 = "187767134", id9 = "187766443", id10 = "189574553", w1 = "UCR1ogynvoEbSksEOQfK4aFA", w2 = "LLR1ogynvoEbSksEOQfK4aFA", w3 = "glqeZ4mxNJ8" });
            Bandsdata.Add(new BandsInfo() { ID = 9, Name = "Wust El Balad", Image = "Assets/west.png", backg = "Assets/wesssss.png", name1 = "Aneqeni Live", name2 = "Karakeb", name3 = "Kedbt Aleek", name4 = "Mawlay", name5 = "3in El Qmr", name6 = "Yemkn", name7 = "Yama", name8 = "Wa7dy", name9 = "Shagaret Gwafa", name10 = "khalik adha", id1 = "79027209", id2 = "145166033", id3 = "37727607", id4 = "151824198", id5 = "18754833", id6 = "19354397", id7 = "19213874", id8 = "48658113", id9 = "129639788", id10 = "81044493", w1 = "UCfDaRZkKQE981NMO8hFPBrg", w2 = "PLu1hCB5zkVa_x4maEOPI9nHxuEoGQ7cdm", w3 = "245PJAy8ank" });
            Bandsdata.Add(new BandsInfo() { ID = 10, Name = "Zap Tharwat", Image = "Assets/zap.png", backg = "Assets/zapaaaa.png", name1 = "Men El Sabb", name2 = "Ana batl", name3 = "Mestaneek", name4 = "E7na geel", name5 = "E7lam", name6 = "7a22y", name7 = "Islamophobia", name8 = "Kam Wa7ed", name9 = "Meen El Ma2soud", name10 = "Di 7ayaty", id1 = "162556730", id2 = "196135778", id3 = "161127369", id4 = "54187046", id5 = "53987859", id6 = "73264939", id7 = "54187046", id8 = "56106122", id9 = "56114911", id10 = "124087446", w1 = "UCYmjRHj3JhpWvrBjClZLnDw", w2 = "PLTFb9R58Fgt26s1FIvX3Y4IRRPMfIuPWS", w3 = "MPjt0HFoe5I" });
            Bandsdata.Add(new BandsInfo() { ID = 11, Name = "Soot Fel El Za7ma", Image = "Assets/sot.png", backg = "Assets/soot.png", name1 = "T3ashab Shay", name2 = "Sees", name3 = "Have Fan Festival", name4 = "Ashky Lmeen", name5 = "Zar", name6 = "Salby", name7 = "Kalam Abee7", name8 = "E3mel 3abeit", name9 = "Farah el Bahr", name10 = "SeeS ", id1 = "28431382", id2 = "152524601", id3 = "23799608", id4 = "120397357", id5 = "598645", id6 = "28431382", id7 = "132820150", id8 = "141756550", id9 = "135733723", id10 = "152524601", w1 = "UCiSOIJgD-Nczsvdu2dw4BCA", w2 = "FLiSOIJgD-Nczsvdu2dw4BCA", w3 = "ZNEQwJHoX7U" });
            Bandsdata.Add(new BandsInfo() { ID = 12, Name = "Salalem", Image = "Assets/sal.png", backg = "Assets/salbg.png", name1 = "Kelma Abee7a", name2 = "Ew3a Tedaye2", name3 = "La3allo Kheir", name4 = "Ma ytloboh el m7zoron", name5 = "Mazzika", name6 = "Ayoha El Sha3b", name7 = "bian", name8 = "Mish Mehtam", name9 = "Atama ", name10 = "Zahma ", id1 = "71089498", id2 = "203873165", id3 = "121684860", id4 = "203873165", id5 = "104108191", id6 = "106213964", id7 = "74887467", id8 = "87426288", id9 = "71564646", id10 = "71565099", w1 = "UCsDeH7UUEv1G0Jo0G6n0nlg", w2 = "PLFxDD3vhiEgrIMBsQrQoqZ3pNFZ_KdW_I", w3 = "faSTUVNVImA" });
            Bandsdata.Add(new BandsInfo() { ID = 14, Name = "Basata", Image = "Assets/bas.png", backg = "Assets/basbg.png", name1 = "El 72eny", name2 = "3sl na7l", name3 = "kdab", name4 = "Adi El 7kaya", name5 = "El 5yam", name6 = "El Leil", name7 = "Htgawz", name8 = "Shgraya s3'yora", name9 = "7alna 7al", name10 = "Abla Fadila", id1 = "79613492", id2 = "79613488", id3 = "81185511", id4 = "79613490", id5 = "81185513", id6 = "79615896", id7 = "70687516", id8 = "81183547", id9 = "70120608", id10 = "56510280", w1 = "UC0HVog6eisNvMeRZmWJCEiw", w2 = "FL0HVog6eisNvMeRZmWJCEiw", w3 = "v_vDV2ip88s" });
           
        }
    }
}
