using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SocialManager{

    public NPCManager npc = new NPCManager();

    public List<Interest> interests = new List<Interest>();
    public List<Relationship> relationships = new List<Relationship>();

    public void createRelationships()
    {
        relationships.Add(new Relationship(new Player(), npc.characters.Find(x => x.name.Contains("Mom"))));
        relationships.Add(new Relationship(new Player(), npc.characters.Find(x => x.name.Contains("Dad"))));
        relationships.Add(new Relationship(new Player(), npc.characters.Find(x => x.name.Contains("Brother"))));
        relationships.Add(new Relationship(new Player(), npc.characters.Find(x => x.name.Contains("Sister"))));
        relationships.Add(new Relationship(new Player(), npc.characters.Find(x => x.name.Contains("Grandpa"))));
    }
    
    public void createNewRelationship(Character a, Character b)
    {
        relationships.Add(new Relationship(a, b));
    }

    public void createNewRelationship(Character a, Character b, States state, float value)
    {
        relationships.Add(new Relationship(a, b, state, value));
    }

    public void createInterests()
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
        interests.Add(new Interest(48, "", "FOOD"));
        interests.Add(new Interest(49, "", "FOOD"));
        interests.Add(new Interest(50, "", "FOOD"));
        interests.Add(new Interest(51, "", "FOOD"));
        interests.Add(new Interest(52, "", "FOOD"));
        interests.Add(new Interest(53, "", "FOOD"));
        interests.Add(new Interest(54, "", "FOOD"));
        interests.Add(new Interest(55, "", "FOOD"));
        interests.Add(new Interest(56, "", "FOOD"));
        interests.Add(new Interest(57, "", "FOOD"));
        interests.Add(new Interest(58, "", "FOOD"));
        interests.Add(new Interest(59, "", "FOOD"));
        interests.Add(new Interest(60, "", "FOOD"));
        interests.Add(new Interest(61, "", "FOOD"));
        interests.Add(new Interest(62, "", "FOOD"));
        interests.Add(new Interest(63, "", "FOOD"));
        interests.Add(new Interest(64, "", "FOOD"));
        interests.Add(new Interest(65, "", "FOOD"));
        interests.Add(new Interest(66, "", "FOOD"));
        interests.Add(new Interest(67, "", "FOOD"));
        interests.Add(new Interest(68, "", "FOOD"));
        interests.Add(new Interest(69, "", "FOOD"));
        interests.Add(new Interest(70, "", "FOOD"));
        interests.Add(new Interest(71, "", "FOOD"));
        interests.Add(new Interest(72, "", "FOOD"));
        interests.Add(new Interest(73, "", "FOOD"));
        interests.Add(new Interest(74, "", "FOOD"));
        interests.Add(new Interest(75, "", "FOOD"));
        interests.Add(new Interest(76, "", "FOOD"));
        interests.Add(new Interest(77, "", "FOOD"));
        interests.Add(new Interest(78, "", "FOOD"));
        interests.Add(new Interest(79, "", "FOOD"));
        interests.Add(new Interest(80, "", "FOOD"));

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
        interests.Add(new Interest(119, "", "DRINKS"));
        interests.Add(new Interest(120, "", "DRINKS"));

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
        interests.Add(new Interest(139, "", "SPORS"));
        interests.Add(new Interest(140, "", "SPORTS"));

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
        interests.Add(new Interest(169, "", "MARTIAL ARTS"));
        interests.Add(new Interest(170, "", "MARTIAL ARTS"));
        interests.Add(new Interest(171, "", "MARTIAL ARTS"));
        interests.Add(new Interest(172, "", "MARTIAL ARTS"));
        interests.Add(new Interest(173, "", "MARTIAL ARTS"));
        interests.Add(new Interest(174, "", "MARTIAL ARTS"));
        interests.Add(new Interest(175, "", "MARTIAL ARTS"));
        interests.Add(new Interest(176, "", "MARTIAL ARTS"));
        interests.Add(new Interest(177, "", "MARTIAL ARTS"));
        interests.Add(new Interest(178, "", "MARTIAL ARTS"));
        interests.Add(new Interest(179, "", "MARTIAL ARTS"));
        interests.Add(new Interest(180, "", "MARTIAL ARTS"));


        //ARTCRAFT
        interests.Add(new Interest(181, "DESIGNING", "ARTCRAFT"));
        interests.Add(new Interest(182, "COOKING", "ARTCRAFT"));
        interests.Add(new Interest(183, "KNITTING", "ARTCRAFT"));
        interests.Add(new Interest(184, "SEWING", "ARTCRAFT"));
        interests.Add(new Interest(185, "DRAWING", "ARTCRAFT"));
        interests.Add(new Interest(186, "CRAFTING", "ARTCRAFT"));
        interests.Add(new Interest(187, "SMITHING", "ARTCRAFT"));
        interests.Add(new Interest(188, "MODELLING", "ARTCRAFT"));
        interests.Add(new Interest(189, "PIXELING", "ARTCRAFT"));
        interests.Add(new Interest(190, "PROGRAMMING", "ARTCRAFT"));
        interests.Add(new Interest(191, "DEVELOPING", "ARTCRAFT"));
        interests.Add(new Interest(192, "COMPOSING", "ARTCRAFT"));
        interests.Add(new Interest(193, "", "ARTCRAFT"));
        interests.Add(new Interest(194, "", "ARTCRAFT"));
        interests.Add(new Interest(195, "", "ARTCRAFT"));
        interests.Add(new Interest(196, "", "ARTCRAFT"));
        interests.Add(new Interest(197, "", "ARTCRAFT"));
        interests.Add(new Interest(198, "", "ARTCRAFT"));
        interests.Add(new Interest(199, "", "ARTCRAFT"));
        interests.Add(new Interest(200, "", "ARTCRAFT"));

        //MOVIES
            //HORROR
            interests.Add(new Interest(201, "NIGHTMARE ON ELMSTREET", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "SHINING", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "PSYCHO", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "THE DANCE OF THE DEVIL", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //THRILLER
            interests.Add(new Interest(211, "THE SILENCE OF THE LAMBS", "MOVIES", "THRILLER"));
            interests.Add(new Interest(212, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(213, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(214, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(215, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(216, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(217, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(218, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(219, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(220, "", "MOVIES", "THRILLER"));

            //DRAMA
            interests.Add(new Interest(221, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(222, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(223, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(224, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(225, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(226, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(227, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(228, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(229, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(230, "", "MOVIES", "DRAMA"));

            //COMEDY
            interests.Add(new Interest(241, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(242, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(243, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(244, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(245, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(246, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(247, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(248, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(249, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(250, "", "MOVIES", "COMEDY"));

            //ACTION
            interests.Add(new Interest(251, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(252, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(253, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(254, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(255, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(256, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(257, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(258, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(259, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(260, "", "MOVIES", "ACTION"));

            //KIDS
            interests.Add(new Interest(261, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(262, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(263, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(264, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(265, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(266, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(267, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(268, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(269, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(270, "", "MOVIES", "KIDS"));

            //FANTASY
            interests.Add(new Interest(271, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(272, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(273, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(274, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(275, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(276, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(277, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(278, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(279, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(280, "", "MOVIES", "FANTASY"));

            //SCI-FI
            interests.Add(new Interest(281, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(282, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(283, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(284, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(285, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(286, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(287, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(288, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(289, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(290, "", "MOVIES", "SCI-FI"));

            //ROMANCE
            interests.Add(new Interest(301, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(302, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(303, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(304, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(305, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(306, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(307, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(308, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(309, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(310, "", "MOVIES", "ROMANCE"));

        //TV-SHOWS
            //HORROR
            interests.Add(new Interest(311, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(312, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(313, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(314, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(315, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(316, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(317, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(318, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(319, "", "TV-SHOWS", "HORROR"));
            interests.Add(new Interest(320, "", "TV-SHOWS", "HORROR"));

            //THRILLER
            interests.Add(new Interest(321, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(322, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(323, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(324, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(325, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(326, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(327, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(328, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(329, "", "TV-SHOWS", "THRILLER"));
            interests.Add(new Interest(330, "", "TV-SHOWS", "THRILLER"));

            //DRAMA
            interests.Add(new Interest(331, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(332, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(333, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(334, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(335, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(336, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(337, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(338, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(339, "", "TV-SHOWS", "DRAMA"));
            interests.Add(new Interest(340, "", "TV-SHOWS", "DRAMA"));

            //COMEDY
            interests.Add(new Interest(341, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(342, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(343, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(344, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(345, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(346, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(347, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(348, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(349, "", "TV-SHOWS", "COMEDY"));
            interests.Add(new Interest(350, "", "TV-SHOWS", "COMEDY"));

            //ACTION
            interests.Add(new Interest(351, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(352, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(353, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(354, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(355, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(356, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(357, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(358, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(359, "", "TV-SHOWS", "ACTION"));
            interests.Add(new Interest(360, "", "TV-SHOWS", "ACTION"));
    
            //KIDS
            interests.Add(new Interest(361, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(362, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(363, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(364, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(365, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(366, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(367, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(368, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(369, "", "TV-SHOWS", "KIDS"));
            interests.Add(new Interest(370, "", "TV-SHOWS", "KIDS"));

            //FANTASY
            interests.Add(new Interest(371, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(372, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(373, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(374, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(375, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(376, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(377, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(378, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(379, "", "TV-SHOWS", "FANTASY"));
            interests.Add(new Interest(380, "", "TV-SHOWS", "FANTASY"));

            //SCI-FI
            interests.Add(new Interest(381, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(382, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(383, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(384, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(385, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(386, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(387, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(388, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(389, "", "TV-SHOWS", "SCI-FI"));
            interests.Add(new Interest(390, "", "TV-SHOWS", "SCI-FI"));

            //ROMANCE
            interests.Add(new Interest(391, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(392, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(393, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(394, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(395, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(396, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(397, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(398, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(399, "", "TV-SHOWS", "ROMANCE"));
            interests.Add(new Interest(400, "", "TV-SHOWS", "ROMANCE"));

        //ANIME
            //HORROR
            interests.Add(new Interest(401, "", "ANIME", "HORROR"));
            interests.Add(new Interest(402, "", "ANIME", "HORROR"));
            interests.Add(new Interest(403, "", "ANIME", "HORROR"));
            interests.Add(new Interest(404, "", "ANIME", "HORROR"));
            interests.Add(new Interest(405, "", "ANIME", "HORROR"));
            interests.Add(new Interest(406, "", "ANIME", "HORROR"));
            interests.Add(new Interest(407, "", "ANIME", "HORROR"));
            interests.Add(new Interest(408, "", "ANIME", "HORROR"));
            interests.Add(new Interest(409, "", "ANIME", "HORROR"));
            interests.Add(new Interest(410, "", "ANIME", "HORROR"));

            //PSYCHOLOGICAL
            interests.Add(new Interest(411, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(412, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(413, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(414, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(415, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(416, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(417, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(418, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(419, "", "ANIME", "PSYCHOLOGICAL"));
            interests.Add(new Interest(420, "", "ANIME", "PSYCHOLOGICAL"));

            //DRAMA
            interests.Add(new Interest(421, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(422, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(423, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(424, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(425, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(426, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(427, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(428, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(429, "", "ANIME", "DRAMA"));
            interests.Add(new Interest(430, "", "ANIME", "DRAMA"));

            //COMEDY
            interests.Add(new Interest(431, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(432, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(433, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(434, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(435, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(436, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(437, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(438, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(439, "", "ANIME", "COMEDY"));
            interests.Add(new Interest(440, "", "ANIME", "COMEDY"));

            //ACTION
            interests.Add(new Interest(441, "", "ANIME", "ACTION"));
            interests.Add(new Interest(442, "", "ANIME", "ACTION"));
            interests.Add(new Interest(443, "", "ANIME", "ACTION"));
            interests.Add(new Interest(444, "", "ANIME", "ACTION"));
            interests.Add(new Interest(445, "", "ANIME", "ACTION"));
            interests.Add(new Interest(446, "", "ANIME", "ACTION"));
            interests.Add(new Interest(447, "", "ANIME", "ACTION"));
            interests.Add(new Interest(448, "", "ANIME", "ACTION"));
            interests.Add(new Interest(449, "", "ANIME", "ACTION"));
            interests.Add(new Interest(450, "", "ANIME", "ACTION"));

            //KIDS
            interests.Add(new Interest(451, "", "ANIME", "KIDS"));
            interests.Add(new Interest(452, "", "ANIME", "KIDS"));
            interests.Add(new Interest(453, "", "ANIME", "KIDS"));
            interests.Add(new Interest(454, "", "ANIME", "KIDS"));
            interests.Add(new Interest(455, "", "ANIME", "KIDS"));
            interests.Add(new Interest(456, "", "ANIME", "KIDS"));
            interests.Add(new Interest(457, "", "ANIME", "KIDS"));
            interests.Add(new Interest(458, "", "ANIME", "KIDS"));
            interests.Add(new Interest(459, "", "ANIME", "KIDS"));
            interests.Add(new Interest(460, "", "ANIME", "KIDS"));

            //FANTASY
            interests.Add(new Interest(461, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(462, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(463, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(464, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(465, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(466, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(467, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(468, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(469, "", "ANIME", "FANTASY"));
            interests.Add(new Interest(470, "", "ANIME", "FANTASY"));

            //GAME
            interests.Add(new Interest(471, "", "ANIME", "GAME"));
            interests.Add(new Interest(472, "", "ANIME", "GAME"));
            interests.Add(new Interest(473, "", "ANIME", "GAME"));
            interests.Add(new Interest(474, "", "ANIME", "GAME"));
            interests.Add(new Interest(475, "", "ANIME", "GAME"));
            interests.Add(new Interest(476, "", "ANIME", "GAME"));
            interests.Add(new Interest(477, "", "ANIME", "GAME"));
            interests.Add(new Interest(478, "", "ANIME", "GAME"));
            interests.Add(new Interest(479, "", "ANIME", "GAME"));
            interests.Add(new Interest(480, "", "ANIME", "GAME"));

            //ROMANCE
            interests.Add(new Interest(481, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(482, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(483, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(484, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(485, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(486, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(487, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(488, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(489, "", "ANIME", "ROMANCE"));
            interests.Add(new Interest(490, "", "ANIME", "ROMANCE"));

            //SHOUNEN
            interests.Add(new Interest(491, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(492, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(493, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(494, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(495, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(496, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(497, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(498, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(499, "", "ANIME", "SHOUNEN"));
            interests.Add(new Interest(500, "", "ANIME", "SHOUNEN"));

            //SHOUJOU
            interests.Add(new Interest(501, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(502, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(503, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(504, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(505, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(506, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(507, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(508, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(509, "", "ANIME", "SHOUJOU"));
            interests.Add(new Interest(510, "", "ANIME", "SHOUJOU"));

            //YAOI
            interests.Add(new Interest(511, "", "ANIME", "YAOI"));
            interests.Add(new Interest(512, "", "ANIME", "YAOI"));
            interests.Add(new Interest(513, "", "ANIME", "YAOI"));
            interests.Add(new Interest(514, "", "ANIME", "YAOI"));
            interests.Add(new Interest(515, "", "ANIME", "YAOI"));
            interests.Add(new Interest(516, "", "ANIME", "YAOI"));
            interests.Add(new Interest(517, "", "ANIME", "YAOI"));
            interests.Add(new Interest(518, "", "ANIME", "YAOI"));
            interests.Add(new Interest(519, "", "ANIME", "YAOI"));
            interests.Add(new Interest(520, "", "ANIME", "YAOI"));

            //YURI
            interests.Add(new Interest(521, "", "ANIME", "YURI"));
            interests.Add(new Interest(522, "", "ANIME", "YURI"));
            interests.Add(new Interest(523, "", "ANIME", "YURI"));
            interests.Add(new Interest(524, "", "ANIME", "YURI"));
            interests.Add(new Interest(525, "", "ANIME", "YURI"));
            interests.Add(new Interest(526, "", "ANIME", "YURI"));
            interests.Add(new Interest(527, "", "ANIME", "YURI"));
            interests.Add(new Interest(528, "", "ANIME", "YURI"));
            interests.Add(new Interest(529, "", "ANIME", "YURI"));
            interests.Add(new Interest(530, "", "ANIME", "YURI"));

            //ECCHI
            interests.Add(new Interest(531, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(532, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(533, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(534, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(535, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(536, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(537, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(538, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(539, "", "ANIME", "ECCHI"));
            interests.Add(new Interest(540, "", "ANIME", "ECCHI"));

            //SLICE OF LIFE
            interests.Add(new Interest(541, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(542, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(543, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(544, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(545, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(546, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(547, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(548, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(549, "", "ANIME", "SLICE OF LIFE"));
            interests.Add(new Interest(550, "", "ANIME", "SLICE OF LIFE"));

            //MAGIC
            interests.Add(new Interest(551, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(552, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(553, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(554, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(555, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(556, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(557, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(558, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(559, "", "ANIME", "MAGIC"));
            interests.Add(new Interest(560, "", "ANIME", "MAGIC"));

            //MYSTERY
            interests.Add(new Interest(561, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(562, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(563, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(564, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(565, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(566, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(567, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(568, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(569, "", "ANIME", "MYSTERY"));
            interests.Add(new Interest(570, "", "ANIME", "MYSTERY"));

            //SUPER POWER
            interests.Add(new Interest(201, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(202, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(203, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(204, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(205, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(206, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(207, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(208, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(209, "", "ANIME", "SUPER POWER"));
            interests.Add(new Interest(210, "", "ANIME", "SUPER POWER"));

            //SPORTS
            interests.Add(new Interest(201, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(202, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(203, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(204, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(205, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(206, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(207, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(208, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(209, "", "ANIME", "SPORTS"));
            interests.Add(new Interest(210, "", "ANIME", "SPORTS"));

        //MANGA
            //HORROR
            interests.Add(new Interest(401, "", "MANGA", "HORROR"));
            interests.Add(new Interest(402, "", "MANGA", "HORROR"));
            interests.Add(new Interest(403, "", "MANGA", "HORROR"));
            interests.Add(new Interest(404, "", "MANGA", "HORROR"));
            interests.Add(new Interest(405, "", "MANGA", "HORROR"));
            interests.Add(new Interest(406, "", "MANGA", "HORROR"));
            interests.Add(new Interest(407, "", "MANGA", "HORROR"));
            interests.Add(new Interest(408, "", "MANGA", "HORROR"));
            interests.Add(new Interest(409, "", "MANGA", "HORROR"));
            interests.Add(new Interest(410, "", "MANGA", "HORROR"));

            //PSYCHOLOGICAL
            interests.Add(new Interest(411, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(412, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(413, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(414, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(415, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(416, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(417, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(418, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(419, "", "MANGA", "PSYCHOLOGICAL"));
            interests.Add(new Interest(420, "", "MANGA", "PSYCHOLOGICAL"));

            //DRAMA
            interests.Add(new Interest(421, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(422, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(423, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(424, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(425, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(426, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(427, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(428, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(429, "", "MANGA", "DRAMA"));
            interests.Add(new Interest(430, "", "MANGA", "DRAMA"));

            //COMEDY
            interests.Add(new Interest(201, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(202, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(203, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(204, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(205, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(206, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(207, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(208, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(209, "", "MANGA", "COMEDY"));
            interests.Add(new Interest(210, "", "MANGA", "COMEDY"));

            //ACTION
            interests.Add(new Interest(201, "", "MANGA", "ACTION"));
            interests.Add(new Interest(202, "", "MANGA", "ACTION"));
            interests.Add(new Interest(203, "", "MANGA", "ACTION"));
            interests.Add(new Interest(204, "", "MANGA", "ACTION"));
            interests.Add(new Interest(205, "", "MANGA", "ACTION"));
            interests.Add(new Interest(206, "", "MANGA", "ACTION"));
            interests.Add(new Interest(207, "", "MANGA", "ACTION"));
            interests.Add(new Interest(208, "", "MANGA", "ACTION"));
            interests.Add(new Interest(209, "", "MANGA", "ACTION"));
            interests.Add(new Interest(210, "", "MANGA", "ACTION"));

            //KIDS
            interests.Add(new Interest(201, "", "MANGA", "KIDS"));
            interests.Add(new Interest(202, "", "MANGA", "KIDS"));
            interests.Add(new Interest(203, "", "MANGA", "KIDS"));
            interests.Add(new Interest(204, "", "MANGA", "KIDS"));
            interests.Add(new Interest(205, "", "MANGA", "KIDS"));
            interests.Add(new Interest(206, "", "MANGA", "KIDS"));
            interests.Add(new Interest(207, "", "MANGA", "KIDS"));
            interests.Add(new Interest(208, "", "MANGA", "KIDS"));
            interests.Add(new Interest(209, "", "MANGA", "KIDS"));
            interests.Add(new Interest(210, "", "MANGA", "KIDS"));

            //FANTASY
            interests.Add(new Interest(201, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(202, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(203, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(204, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(205, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(206, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(207, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(208, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(209, "", "MANGA", "FANTASY"));
            interests.Add(new Interest(210, "", "MANGA", "FANTASY"));

            //GAME
            interests.Add(new Interest(201, "", "MANGA", "GAME"));
            interests.Add(new Interest(202, "", "MANGA", "GAME"));
            interests.Add(new Interest(203, "", "MANGA", "GAME"));
            interests.Add(new Interest(204, "", "MANGA", "GAME"));
            interests.Add(new Interest(205, "", "MANGA", "GAME"));
            interests.Add(new Interest(206, "", "MANGA", "GAME"));
            interests.Add(new Interest(207, "", "MANGA", "GAME"));
            interests.Add(new Interest(208, "", "MANGA", "GAME"));
            interests.Add(new Interest(209, "", "MANGA", "GAME"));
            interests.Add(new Interest(210, "", "MANGA", "GAME"));

            //ROMANCE
            interests.Add(new Interest(201, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(202, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(203, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(204, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(205, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(206, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(207, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(208, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(209, "", "MANGA", "ROMANCE"));
            interests.Add(new Interest(210, "", "MANGA", "ROMANCE"));

            //SHOUNEN
            interests.Add(new Interest(201, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(202, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(203, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(204, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(205, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(206, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(207, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(208, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(209, "", "MANGA", "SHOUNEN"));
            interests.Add(new Interest(210, "", "MANGA", "SHOUNEN"));

            //SHOUJOU
            interests.Add(new Interest(201, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(202, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(203, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(204, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(205, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(206, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(207, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(208, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(209, "", "MANGA", "SHOUJOU"));
            interests.Add(new Interest(210, "", "MANGA", "SHOUJOU"));

            //YAOI
            interests.Add(new Interest(201, "", "MANGA", "YAOI"));
            interests.Add(new Interest(202, "", "MANGA", "YAOI"));
            interests.Add(new Interest(203, "", "MANGA", "YAOI"));
            interests.Add(new Interest(204, "", "MANGA", "YAOI"));
            interests.Add(new Interest(205, "", "MANGA", "YAOI"));
            interests.Add(new Interest(206, "", "MANGA", "YAOI"));
            interests.Add(new Interest(207, "", "MANGA", "YAOI"));
            interests.Add(new Interest(208, "", "MANGA", "YAOI"));
            interests.Add(new Interest(209, "", "MANGA", "YAOI"));
            interests.Add(new Interest(210, "", "MANGA", "YAOI"));

            //YURI
            interests.Add(new Interest(201, "", "MANGA", "YURI"));
            interests.Add(new Interest(202, "", "MANGA", "YURI"));
            interests.Add(new Interest(203, "", "MANGA", "YURI"));
            interests.Add(new Interest(204, "", "MANGA", "YURI"));
            interests.Add(new Interest(205, "", "MANGA", "YURI"));
            interests.Add(new Interest(206, "", "MANGA", "YURI"));
            interests.Add(new Interest(207, "", "MANGA", "YURI"));
            interests.Add(new Interest(208, "", "MANGA", "YURI"));
            interests.Add(new Interest(209, "", "MANGA", "YURI"));
            interests.Add(new Interest(210, "", "MANGA", "YURI"));

            //ECCHI
            interests.Add(new Interest(201, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(202, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(203, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(204, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(205, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(206, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(207, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(208, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(209, "", "MANGA", "ECCHI"));
            interests.Add(new Interest(210, "", "MANGA", "ECCHI"));

            //SLICE OF LIFE
            interests.Add(new Interest(201, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(202, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(203, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(204, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(205, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(206, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(207, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(208, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(209, "", "MANGA", "SLICE OF LIFE"));
            interests.Add(new Interest(210, "", "MANGA", "SLICE OF LIFE"));

            //MAGIC
            interests.Add(new Interest(201, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(202, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(203, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(204, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(205, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(206, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(207, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(208, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(209, "", "MANGA", "MAGIC"));
            interests.Add(new Interest(210, "", "MANGA", "MAGIC"));

            //MYSTERY
            interests.Add(new Interest(201, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(202, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(203, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(204, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(205, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(206, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(207, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(208, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(209, "", "MANGA", "MYSTERY"));
            interests.Add(new Interest(210, "", "MANGA", "MYSTERY"));

            //SUPER POWER
            interests.Add(new Interest(201, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(202, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(203, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(204, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(205, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(206, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(207, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(208, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(209, "", "MANGA", "SUPER POWER"));
            interests.Add(new Interest(210, "", "MANGA", "SUPER POWER"));

            //SPORTS
            interests.Add(new Interest(201, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(202, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(203, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(204, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(205, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(206, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(207, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(208, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(209, "", "MANGA", "SPORTS"));
            interests.Add(new Interest(210, "", "MANGA", "SPORTS"));

        //BOOKS
            //NOVELS
            interests.Add(new Interest(201, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(202, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(203, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(204, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(205, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(206, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(207, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(208, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(209, "", "BOOKS", "NOVELS"));
            interests.Add(new Interest(210, "", "BOOKS", "NOVELS"));

            //POEMS
            interests.Add(new Interest(201, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(202, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(203, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(204, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(205, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(206, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(207, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(208, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(209, "", "BOOKS", "POEMS"));
            interests.Add(new Interest(210, "", "BOOKS", "POEMS"));

            //SHORT STORY
            interests.Add(new Interest(201, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(202, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(203, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(204, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(205, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(206, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(207, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(208, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(209, "", "BOOKS", "SHORT STORY"));
            interests.Add(new Interest(210, "", "BOOKS", "SHORT STORY"));

            //NOVELLA
            interests.Add(new Interest(201, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(202, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(203, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(204, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(205, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(206, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(207, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(208, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(209, "", "BOOKS", "NOVELLA"));
            interests.Add(new Interest(210, "", "BOOKS", "NOVELLA"));

            //NON-FICTION
            interests.Add(new Interest(201, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(202, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(203, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(204, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(205, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(206, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(207, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(208, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(209, "", "BOOKS", "NON-FICTION"));
            interests.Add(new Interest(210, "", "BOOKS", "NON-FICTION"));

            //AUTOBIOGRAPHY
            interests.Add(new Interest(201, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(202, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(203, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(204, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(205, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(206, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(207, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(208, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(209, "", "BOOKS", "AUTOBIOGRAPHY"));
            interests.Add(new Interest(210, "", "BOOKS", "AUTOBIOGRAPHY"));

            //LETTERS
            interests.Add(new Interest(201, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(202, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(203, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(204, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(205, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(206, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(207, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(208, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(209, "", "BOOKS", "LETTERS"));
            interests.Add(new Interest(210, "", "BOOKS", "LETTERS"));

        //GAMES
            //MMO
            interests.Add(new Interest(201, "", "GAMES", "MMO"));
            interests.Add(new Interest(202, "", "GAMES", "MMO"));
            interests.Add(new Interest(203, "", "GAMES", "MMO"));
            interests.Add(new Interest(204, "", "GAMES", "MMO"));
            interests.Add(new Interest(205, "", "GAMES", "MMO"));
            interests.Add(new Interest(206, "", "GAMES", "MMO"));
            interests.Add(new Interest(207, "", "GAMES", "MMO"));
            interests.Add(new Interest(208, "", "GAMES", "MMO"));
            interests.Add(new Interest(209, "", "GAMES", "MMO"));
            interests.Add(new Interest(210, "", "GAMES", "MMO"));

            //RPG
            interests.Add(new Interest(201, "", "GAMES", "RPG"));
            interests.Add(new Interest(202, "", "GAMES", "RPG"));
            interests.Add(new Interest(203, "", "GAMES", "RPG"));
            interests.Add(new Interest(204, "", "GAMES", "RPG"));
            interests.Add(new Interest(205, "", "GAMES", "RPG"));
            interests.Add(new Interest(206, "", "GAMES", "RPG"));
            interests.Add(new Interest(207, "", "GAMES", "RPG"));
            interests.Add(new Interest(208, "", "GAMES", "RPG"));
            interests.Add(new Interest(209, "", "GAMES", "RPG"));
            interests.Add(new Interest(210, "", "GAMES", "RPG"));

            //BEAT'EM UP
            interests.Add(new Interest(201, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(202, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(203, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(204, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(205, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(206, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(207, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(208, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(209, "", "GAMES", "BEAT'EM UP"));
            interests.Add(new Interest(210, "", "GAMES", "BEAT'EM UP"));

            //SHOOT'EM UP
            interests.Add(new Interest(201, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(202, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(203, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(204, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(205, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(206, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(207, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(208, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(209, "", "GAMES", "SHOOT'EM UP"));
            interests.Add(new Interest(210, "", "GAMES", "SHOOT'EM UP"));

            //SHOOTER
            interests.Add(new Interest(201, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(202, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(203, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(204, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(205, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(206, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(207, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(208, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(209, "", "GAMES", "SHOOTER"));
            interests.Add(new Interest(210, "", "GAMES", "SHOOTER"));

            //MYSTERY
            interests.Add(new Interest(201, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(202, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(203, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(204, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(205, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(206, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(207, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(208, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(209, "", "GAMES", "MYSTERY"));
            interests.Add(new Interest(210, "", "GAMES", "MYSTERY"));

            //OPENWORLD
            interests.Add(new Interest(201, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(202, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(203, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(204, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(205, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(206, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(207, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(208, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(209, "", "GAMES", "OPENWORLD"));
            interests.Add(new Interest(210, "", "GAMES", "OPENWORLD"));

             //HACK'N SLASH
            interests.Add(new Interest(201, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(202, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(203, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(204, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(205, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(206, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(207, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(208, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(209, "", "GAMES", "HACK'N SLASH"));
            interests.Add(new Interest(210, "", "GAMES", "HACK'N SLASH"));

            //SANDBOX
            interests.Add(new Interest(201, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(202, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(203, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(204, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(205, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(206, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(207, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(208, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(209, "", "GAMES", "SANDBOX"));
            interests.Add(new Interest(210, "", "GAMES", "SANDBOX"));

            //MOBA
            interests.Add(new Interest(201, "", "GAMES", "MOBA"));
            interests.Add(new Interest(202, "", "GAMES", "MOBA"));
            interests.Add(new Interest(203, "", "GAMES", "MOBA"));
            interests.Add(new Interest(204, "", "GAMES", "MOBA"));
            interests.Add(new Interest(205, "", "GAMES", "MOBA"));
            interests.Add(new Interest(206, "", "GAMES", "MOBA"));
            interests.Add(new Interest(207, "", "GAMES", "MOBA"));
            interests.Add(new Interest(208, "", "GAMES", "MOBA"));
            interests.Add(new Interest(209, "", "GAMES", "MOBA"));
            interests.Add(new Interest(210, "", "GAMES", "MOBA"));

            //VISUAL NOVEL
            interests.Add(new Interest(201, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(202, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(203, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(204, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(205, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(206, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(207, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(208, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(209, "", "GAMES", "VISUAL NOVEL"));
            interests.Add(new Interest(210, "", "GAMES", "VISUAL NOVEL"));

            //DATING-SIMULATION
            interests.Add(new Interest(201, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(202, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(203, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(204, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(205, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(206, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(207, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(208, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(209, "", "GAMES", "DATING-SIMULATION"));
            interests.Add(new Interest(210, "", "GAMES", "DATING-SIMULATION"));

            //SIDESCROLLER
            interests.Add(new Interest(201, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(202, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(203, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(204, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(205, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(206, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(207, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(208, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(209, "", "GAMES", "SIDESCROLLER"));
            interests.Add(new Interest(210, "", "GAMES", "SIDESCROLLER"));

        //TECHNOLOGIES

        //TRAVELLING

        //OCCULTIC
    }
}
