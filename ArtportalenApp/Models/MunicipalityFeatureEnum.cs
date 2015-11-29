﻿using System.ComponentModel.DataAnnotations;

namespace ArtportalenApp.Models
{

    public enum MunicipalityFeatureEnum
    {
        [Display(Name = "")]Undefined = 0,
        [Display(Name = "Upplands Väsby")]UpplandsVäsby = 0114,
        Vallentuna = 0115,
        Österåker = 0117,
        Värmdö = 0120,
        Järfälla = 0123,
        Ekerö = 0125,
        Huddinge = 0126,
        Botkyrka = 0127,
        Salem = 0128,
        Haninge = 0136,
        Tyresö = 0138,
        [Display(Name = "Upplands-Bro")]UpplandsBro = 0139,
        Nykvarn = 0140,
        Täby = 0160,
        Danderyd = 0162,
        Sollentuna = 0163,
        Stockholm = 0180,
        Södertälje = 0181,
        Nacka = 0182,
        Sundbyberg = 0183,
        Solna = 0184,
        Lidingö = 0186,
        Vaxholm = 0187,
        Norrtälje = 0188,
        Sigtuna = 0191,
        Nynäshamn = 0192,
        Håbo = 0305,
        Älvkarleby = 0319,
        Knivsta = 0330,
        Heby = 0331,
        Tierp = 0360,
        Uppsala = 0380,
        Enköping = 0381,
        Östhammar = 0382,
        Vingåker = 0428,
        Gnesta = 0461,
        Nyköping = 0480,
        Oxelösund = 0481,
        Flen = 0482,
        Katrineholm = 0483,
        Eskilstuna = 0484,
        Strängnäs = 0486,
        Trosa = 0488,
        Ödeshög = 0509,
        Ydre = 0512,
        Kinda = 0513,
        Boxholm = 0560,
        Åtvidaberg = 0561,
        Finspång = 0562,
        Valdemarsvik = 0563,
        Linköping = 0580,
        Norrköping = 0581,
        Söderköping = 0582,
        Motala = 0583,
        Vadstena = 0584,
        Mjölby = 0586,
        Aneby = 0604,
        Gnosjö = 0617,
        Mullsjö = 0642,
        Habo = 0643,
        Gislaved = 0662,
        Vaggeryd = 0665,
        Jönköping = 0680,
        Nässjö = 0682,
        Värnamo = 0683,
        Sävsjö = 0684,
        Vetlanda = 0685,
        Eksjö = 0686,
        Tranås = 0687,
        Uppvidinge = 0760,
        Lessebo = 0761,
        Tingsryd = 0763,
        Alvesta = 0764,
        Älmhult = 0765,
        Markaryd = 0767,
        Växjö = 0780,
        Ljungby = 0781,
        Högsby = 0821,
        Torsås = 0834,
        Mörbylånga = 0840,
        Hultsfred = 0860,
        Mönsterås = 0861,
        Emmaboda = 0862,
        Kalmar = 0880,
        Nybro = 0881,
        Oskarshamn = 0882,
        Västervik = 0883,
        Vimmerby = 0884,
        Borgholm = 0885,
        Gotland = 0980,
        Olofström = 1060,
        Karlskrona = 1080,
        Ronneby = 1081,
        Karlshamn = 1082,
        Sölvesborg = 1083,
        Svalöv = 1214,
        Staffanstorp = 1230,
        Burlöv = 1231,
        Vellinge = 1233,
        [Display(Name = "Östra Göinge")]ÖstraGöinge = 1256,
        Örkelljunga = 1257,
        Bjuv = 1260,
        Kävlinge = 1261,
        Lomma = 1262,
        Svedala = 1263,
        Skurup = 1264,
        Sjöbo = 1265,
        Hörby = 1266,
        Höör = 1267,
        Tomelilla = 1270,
        Bromölla = 1272,
        Osby = 1273,
        Perstorp = 1275,
        Klippan = 1276,
        Åstorp = 1277,
        Båstad = 1278,
        Malmö = 1280,
        Lund = 1281,
        Landskrona = 1282,
        Helsingborg = 1283,
        Höganäs = 1284,
        Eslöv = 1285,
        Ystad = 1286,
        Trelleborg = 1287,
        Kristianstad = 1290,
        Simrishamn = 1291,
        Ängelholm = 1292,
        Hässleholm = 1293,
        Hylte = 1315,
        Halmstad = 1380,
        Laholm = 1381,
        Falkenberg = 1382,
        Varberg = 1383,
        Kungsbacka = 1384,
        Härryda = 1401,
        Partille = 1402,
        Öckerö = 1407,
        Stenungsund = 1415,
        Tjörn = 1419,
        Orust = 1421,
        Sotenäs = 1427,
        Munkedal = 1430,
        Tanum = 1435,
        [Display(Name = "Dals-Ed")]DalsEd = 1438,
        Färgelanda = 1439,
        Ale = 1440,
        Lerum = 1441,
        Vårgårda = 1442,
        Bollebygd = 1443,
        Grästorp = 1444,
        Essunga = 1445,
        Karlsborg = 1446,
        Gullspång = 1447,
        Tranemo = 1452,
        Bengtsfors = 1460,
        Mellerud = 1461,
        [Display(Name = "Lilla Edet")]LillaEdet = 1462,
        Mark = 1463,
        Svenljunga = 1465,
        Herrljunga = 1466,
        Vara = 1470,
        Götene = 1471,
        Tibro = 1472,
        Töreboda = 1473,
        Göteborg = 1480,
        Mölndal = 1481,
        Kungälv = 1482,
        Lysekil = 1484,
        Uddevalla = 1485,
        Strömstad = 1486,
        Vänersborg = 1487,
        Trollhättan = 1488,
        Alingsås = 1489,
        Borås = 1490,
        Ulricehamn = 1491,
        Åmål = 1492,
        Mariestad = 1493,
        Lidköping = 1494,
        Skara = 1495,
        Skövde = 1496,
        Hjo = 1497,
        Tidaholm = 1498,
        Falköping = 1499,
        Kil = 1715,
        Eda = 1730,
        Torsby = 1737,
        Storfors = 1760,
        Hammarö = 1761,
        Munkfors = 1762,
        Forshaga = 1763,
        Grums = 1764,
        Årjäng = 1765,
        Sunne = 1766,
        Karlstad = 1780,
        Kristinehamn = 1781,
        Filipstad = 1782,
        Hagfors = 1783,
        Arvika = 1784,
        Säffle = 1785,
        Lekeberg = 1814,
        Laxå = 1860,
        Hallsberg = 1861,
        Degerfors = 1862,
        Hällefors = 1863,
        Ljusnarsberg = 1864,
        Örebro = 1880,
        Kumla = 1881,
        Askersund = 1882,
        Karlskoga = 1883,
        Nora = 1884,
        Lindesberg = 1885,
        Skinnskatteberg = 1904,
        Surahammar = 1907,
        Kungsör = 1960,
        Hallstahammar = 1961,
        Norberg = 1962,
        Västerås = 1980,
        Sala = 1981,
        Fagersta = 1982,
        Köping = 1983,
        Arboga = 1984,
        Vansbro = 2021,
        [Display(Name = "Malung-Sälen")]MalungSälen = 2023,
        Gagnef = 2026,
        Leksand = 2029,
        Rättvik = 2031,
        Orsa = 2034,
        Älvdalen = 2039,
        Smedjebacken = 2061,
        Mora = 2062,
        Falun = 2080,
        Borlänge = 2081,
        Säter = 2082,
        Hedemora = 2083,
        Avesta = 2084,
        Ludvika = 2085,
        Ockelbo = 2101,
        Hofors = 2104,
        Ovanåker = 2121,
        Nordanstig = 2132,
        Ljusdal = 2161,
        Gävle = 2180,
        Sandviken = 2181,
        Söderhamn = 2182,
        Bollnäs = 2183,
        Hudiksvall = 2184,
        Ånge = 2260,
        Timrå = 2262,
        Härnösand = 2280,
        Sundsvall = 2281,
        Kramfors = 2282,
        Sollefteå = 2283,
        Örnsköldsvik = 2284,
        Ragunda = 2303,
        Bräcke = 2305,
        Krokom = 2309,
        Strömsund = 2313,
        Åre = 2321,
        Berg = 2326,
        Härjedalen = 2361,
        Östersund = 2380,
        Nordmaling = 2401,
        Bjurholm = 2403,
        Vindeln = 2404,
        Robertsfors = 2409,
        Norsjö = 2417,
        Malå = 2418,
        Storuman = 2421,
        Sorsele = 2422,
        Dorotea = 2425,
        Vännäs = 2460,
        Vilhelmina = 2462,
        Åsele = 2463,
        Umeå = 2480,
        Lycksele = 2481,
        Skellefteå = 2482,
        Arvidsjaur = 2505,
        Arjeplog = 2506,
        Jokkmokk = 2510,
        Överkalix = 2513,
        Kalix = 2514,
        Övertorneå = 2518,
        Pajala = 2521,
        Gällivare = 2523,
        Älvsbyn = 2560,
        Luleå = 2580,
        Piteå = 2581,
        Boden = 2582,
        Haparanda = 2583,
        Kiruna = 2584
    }
}