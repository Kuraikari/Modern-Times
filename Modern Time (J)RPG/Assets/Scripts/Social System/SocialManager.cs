using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialManager{

    List<Interest> interests = new List<Interest>();

    public List<Interest> createInterests()
    {
        //DEFAULT
        interests.Add(new Interest(0, "INTERESTS", "DEFAULT"));
        //FOOD
        interests.Add(new Interest(1, "SUSHI", "FOOD"));
        interests.Add(new Interest(2, "SASHIMI", "FOOD"));
        interests.Add(new Interest(3, "TAKOYAKI", "FOOD"));
        interests.Add(new Interest(4, "OMURAISU", "FOOD"));
        interests.Add(new Interest(5, "KARREIRAISU", "FOOD"));
        interests.Add(new Interest(6, "RAMEN", "FOOD"));
        interests.Add(new Interest(7, "UDON", "FOOD"));
        interests.Add(new Interest(8, "TAMAGO", "FOOD"));
        interests.Add(new Interest(9, "MELONPAN", "FOOD"));
        interests.Add(new Interest(10, "EDAMAME", "FOOD"));
        interests.Add(new Interest(11, "MOCHI", "FOOD"));
        interests.Add(new Interest(12, "MUSHIPAN", "FOOD"));
        interests.Add(new Interest(13, "TORIYAKI", "FOOD"));
        interests.Add(new Interest(14, "YAKISOBA", "FOOD"));
        interests.Add(new Interest(15, "HAMBURGER", "FOOD"));
        interests.Add(new Interest(16, "FRIES", "FOOD"));
        interests.Add(new Interest(17, "CHIPS", "FOOD"));
        interests.Add(new Interest(18, "CHICKEN TERIYAKI", "FOOD"));
        interests.Add(new Interest(19, "CAKE", "FOOD"));
        interests.Add(new Interest(20, "CROISSANTS", "FOOD"));
        interests.Add(new Interest(21, "MANDARINES", "FOOD"));
        interests.Add(new Interest(22, "CARROTS", "FOOD"));
        interests.Add(new Interest(23, "SMOKED FISH", "FOOD"));
        interests.Add(new Interest(24, "NOODLES", "FOOD"));
        interests.Add(new Interest(25, "RAVIOLI", "FOOD"));
        interests.Add(new Interest(26, "SPAGHETTI", "FOOD"));
        interests.Add(new Interest(27, "PIZZA", "FOOD"));
        interests.Add(new Interest(28, "LASAGNE", "FOOD"));
        interests.Add(new Interest(29, "TIRAMISU", "FOOD"));
        interests.Add(new Interest(30, "BAGUETTES", "FOOD"));
        interests.Add(new Interest(31, "FRUITSALAD", "FOOD"));
        interests.Add(new Interest(32, "SALAD", "FOOD"));
        interests.Add(new Interest(33, "RICE", "FOOD"));
        interests.Add(new Interest(34, "RACLETTE", "FOOD"));
        interests.Add(new Interest(35, "CHEESE", "FOOD"));
        interests.Add(new Interest(36, "COOKIES", "FOOD"));
        interests.Add(new Interest(37, "PEPERONATA", "FOOD"));
        interests.Add(new Interest(38, "DUCK", "FOOD"));
        interests.Add(new Interest(39, "SOUP", "FOOD"));
        interests.Add(new Interest(40, "GINGER", "FOOD"));
        interests.Add(new Interest(41, "TOMATOES", "FOOD"));
        interests.Add(new Interest(42, "ORANGES", "FOOD"));
        interests.Add(new Interest(43, "APPLES", "FOOD"));
        interests.Add(new Interest(44, "BANANAS", "FOOD"));
        interests.Add(new Interest(45, "ICE", "FOOD"));
        interests.Add(new Interest(46, "COUSCOUS", "FOOD"));
        interests.Add(new Interest(47, "TAJINE", "FOOD"));

        //Drinks
        interests.Add(new Interest(81, "STILL WATER", "DRINKS"));
        interests.Add(new Interest(82, "GAS-INFUSED WATER", "DRINKS"));
        interests.Add(new Interest(83, "ORANGEJUICE", "DRINKS"));
        interests.Add(new Interest(84, "TOMATOEJUICE", "DRINKS"));
        interests.Add(new Interest(85, "GREEN TEA", "DRINKS"));
        interests.Add(new Interest(86, "BLACK TEA", "DRINKS"));
        interests.Add(new Interest(87, "MATCHA TEA", "DRINKS"));
        interests.Add(new Interest(88, "OOLONG TEA", "DRINKS"));
        interests.Add(new Interest(89, "COFFEE", "DRINKS"));
        interests.Add(new Interest(90, "MACCHIATTO", "DRINKS"));
        interests.Add(new Interest(91, "MILK COFFEE", "DRINKS"));
        interests.Add(new Interest(92, "ESPRESSO", "DRINKS"));
        interests.Add(new Interest(93, "RISTRETTO", "DRINKS"));
        interests.Add(new Interest(94, "CAPPUCCINO", "DRINKS"));
        interests.Add(new Interest(95, "COLA", "DRINKS"));
        interests.Add(new Interest(96, "FANTA", "DRINKS"));
        interests.Add(new Interest(97, "LEMONADE", "DRINKS"));
        interests.Add(new Interest(98, "ENERGY DRINK", "DRINKS"));
        interests.Add(new Interest(99, "RIVELLA", "DRINKS"));
        interests.Add(new Interest(101, "MATCHA JUICE", "DRINKS"));
        interests.Add(new Interest(102, "TONIC WATER", "DRINKS"));
        interests.Add(new Interest(103, "GIN", "DRINKS"));
        interests.Add(new Interest(104, "WHISKEY", "DRINKS"));
        interests.Add(new Interest(105, "BEER", "DRINKS"));
        interests.Add(new Interest(106, "TEQUILLA", "DRINKS"));
        interests.Add(new Interest(107, "SAKE", "DRINKS"));
        interests.Add(new Interest(108, "TAPAI", "DRINKS"));
        interests.Add(new Interest(109, "HUANGJIU", "DRINKS"));
        interests.Add(new Interest(110, "SCOTCH", "DRINKS"));
        interests.Add(new Interest(111, "CHERRY", "DRINKS"));
        interests.Add(new Interest(112, "SILVER BULLET", "DRINKS"));
        interests.Add(new Interest(113, "WINE", "DRINKS"));
        interests.Add(new Interest(114, "", "DRINKS"));
        interests.Add(new Interest(115, "", "DRINKS"));
        interests.Add(new Interest(116, "", "DRINKS"));
        interests.Add(new Interest(117, "", "DRINKS"));
        interests.Add(new Interest(118, "", "DRINKS"));

        //SPORTS
        interests.Add(new Interest(121, "BOWLING", "SPORTS"));
        interests.Add(new Interest(122, "CHESS", "SPORTS"));
        interests.Add(new Interest(123, "BASEBALL", "SPORTS"));
        interests.Add(new Interest(124, "VOLLEYBALL", "SPORTS"));
        interests.Add(new Interest(125, "BASKETBALL", "SPORTS"));
        interests.Add(new Interest(126, "FOOTBALL", "SPORTS"));
        interests.Add(new Interest(127, "SOCCER", "SPORTS"));
        interests.Add(new Interest(128, "TENNIS", "SPORTS"));
        interests.Add(new Interest(129, "BADMINTON", "SPORTS"));
        interests.Add(new Interest(130, "PINGPONG", "SPORTS"));
        interests.Add(new Interest(131, "CURLING", "SPORTS"));
        interests.Add(new Interest(132, "ICE HOCKEY", "SPORTS"));
        interests.Add(new Interest(133, "EQUESTRIANISM", "SPORTS"));
        interests.Add(new Interest(134, "CROQUET", "SPORTS"));
        interests.Add(new Interest(135, "CRICKET", "SPORTS"));
        interests.Add(new Interest(136, "SURFING", "SPORTS"));
        interests.Add(new Interest(137, "FREERUN", "SPORTS"));
        interests.Add(new Interest(138, "YOGA", "SPORTS"));

        //MARTIAL ARTS
        interests.Add(new Interest(141, "WING TSUN", "MARTIAL ARTS"));
        interests.Add(new Interest(142, "KRAV MAGA", "MARTIAL ARTS"));
        interests.Add(new Interest(143, "CAPOEIRA", "MARTIAL ARTS"));
        interests.Add(new Interest(144, "KUNG-FU", "MARTIAL ARTS"));
        interests.Add(new Interest(145, "KARATE", "MARTIAL ARTS"));
        interests.Add(new Interest(146, "JUDO", "MARTIAL ARTS"));
        interests.Add(new Interest(147, "KENDO", "MARTIAL ARTS"));
        interests.Add(new Interest(148, "IAIDO", "MARTIAL ARTS"));
        interests.Add(new Interest(149, "JUJUTSU", "MARTIAL ARTS"));
        interests.Add(new Interest(150, "TAEKWONDO", "MARTIAL ARTS"));
        interests.Add(new Interest(151, "SUMO", "MARTIAL ARTS"));
        interests.Add(new Interest(152, "BOXING", "MARTIAL ARTS"));
        interests.Add(new Interest(153, "KICKBOXING", "MARTIAL ARTS"));
        interests.Add(new Interest(154, "THAIBOXING", "MARTIAL ARTS"));
        interests.Add(new Interest(155, "BAFAQUAN", "MARTIAL ARTS"));
        interests.Add(new Interest(156, "BAYINGQUAN", "MARTIAL ARTS"));
        interests.Add(new Interest(157, "FENG SHOU", "MARTIAL ARTS"));
        interests.Add(new Interest(158, "SHOURINJI KENPO", "MARTIAL ARTS"));
        interests.Add(new Interest(159, "RUSSIAN BOXING", "MARTIAL ARTS"));
        interests.Add(new Interest(160, "KYUUDOU", "MARTIAL ARTS"));
        interests.Add(new Interest(161, "NAGINATAJUTSU", "MARTIAL ARTS"));
        interests.Add(new Interest(162, "NIPPON KENPO", "MARTIAL ARTS"));
        interests.Add(new Interest(163, "NINJUTSU", "MARTIAL ARTS"));
        interests.Add(new Interest(164, "BOUJUTSU", "MARTIAL ARTS"));
        interests.Add(new Interest(165, "VAJRA-MUSHTI", "MARTIAL ARTS"));
        interests.Add(new Interest(166, "JEET KUNE DO", "MARTIAL ARTS"));
        interests.Add(new Interest(167, "S.C.A.R.S", "MARTIAL ARTS"));
        interests.Add(new Interest(168, "KAJUKENBO", "MARTIAL ARTS"));

        //ARTCRAFT
        interests.Add(new Interest(181, "DESIGNING", "ARTCRAFT"));
        interests.Add(new Interest(181, "COOKING", "ARTCRAFT"));
        interests.Add(new Interest(181, "KNITTING", "ARTCRAFT"));
        interests.Add(new Interest(181, "SEWING", "ARTCRAFT"));
        interests.Add(new Interest(181, "DRAWING", "ARTCRAFT"));
        interests.Add(new Interest(181, "CRAFTING", "ARTCRAFT"));
        interests.Add(new Interest(181, "SMITHING", "ARTCRAFT"));
        interests.Add(new Interest(181, "", "ARTCRAFT"));
        interests.Add(new Interest(181, "", "ARTCRAFT"));
        interests.Add(new Interest(181, "", "ARTCRAFT"));



        return createInterests();
    }
}
