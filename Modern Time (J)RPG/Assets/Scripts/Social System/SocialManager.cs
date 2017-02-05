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
        interests.Add(new Interest(188, "", "ARTCRAFT"));
        interests.Add(new Interest(189, "", "ARTCRAFT"));
        interests.Add(new Interest(190, "", "ARTCRAFT"));
        interests.Add(new Interest(191, "", "ARTCRAFT"));
        interests.Add(new Interest(192, "", "ARTCRAFT"));
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
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //THRILLER
            interests.Add(new Interest(211, "", "MOVIES", "THRILLER"));
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
            interests.Add(new Interest(311, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(312, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(313, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(314, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(315, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(316, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(317, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(318, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(319, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(320, "", "MOVIES", "HORROR"));

            //THRILLER
            interests.Add(new Interest(321, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(322, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(323, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(324, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(325, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(326, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(327, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(328, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(329, "", "MOVIES", "THRILLER"));
            interests.Add(new Interest(330, "", "MOVIES", "THRILLER"));

            //DRAMA
            interests.Add(new Interest(331, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(332, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(333, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(334, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(335, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(336, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(337, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(338, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(339, "", "MOVIES", "DRAMA"));
            interests.Add(new Interest(340, "", "MOVIES", "DRAMA"));

            //COMEDY
            interests.Add(new Interest(341, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(342, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(343, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(344, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(345, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(346, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(347, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(348, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(349, "", "MOVIES", "COMEDY"));
            interests.Add(new Interest(350, "", "MOVIES", "COMEDY"));

            //ACTION
            interests.Add(new Interest(351, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(352, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(353, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(354, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(355, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(356, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(357, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(358, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(359, "", "MOVIES", "ACTION"));
            interests.Add(new Interest(360, "", "MOVIES", "ACTION"));
    
            //KIDS
            interests.Add(new Interest(361, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(362, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(363, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(364, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(365, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(366, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(367, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(368, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(369, "", "MOVIES", "KIDS"));
            interests.Add(new Interest(370, "", "MOVIES", "KIDS"));

            //FANTASY
            interests.Add(new Interest(371, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(372, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(373, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(374, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(375, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(376, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(377, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(378, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(379, "", "MOVIES", "FANTASY"));
            interests.Add(new Interest(380, "", "MOVIES", "FANTASY"));

            //SCI-FI
            interests.Add(new Interest(381, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(382, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(383, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(384, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(385, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(386, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(387, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(388, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(389, "", "MOVIES", "SCI-FI"));
            interests.Add(new Interest(390, "", "MOVIES", "SCI-FI"));

            //ROMANCE
            interests.Add(new Interest(391, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(392, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(393, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(394, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(395, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(396, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(397, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(398, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(399, "", "MOVIES", "ROMANCE"));
            interests.Add(new Interest(400, "", "MOVIES", "ROMANCE"));

        //ANIMES
            //HORROR
            interests.Add(new Interest(401, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(402, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(403, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(404, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(405, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(406, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(407, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(408, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(409, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(410, "", "MOVIES", "HORROR"));

            //PSYCHOLOGICAL
            interests.Add(new Interest(411, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(412, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(413, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(414, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(415, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(416, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(417, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(418, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(419, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(420, "", "MOVIES", "HORROR"));

            //DRAMA
            interests.Add(new Interest(421, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(422, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(423, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(424, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(425, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(426, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(427, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(428, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(429, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(430, "", "MOVIES", "HORROR"));

            //COMEDY
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //ACTION
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //KIDS
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //FANTASY
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //GAME
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //ROMANCE
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //SHOUNEN
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //SHOUJOU
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //YAOI
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //YURI
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //ECCHI
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //SLICE OF LIFE
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //MAGIC
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //MYSTERY
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //SUPER POWER
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

            //SPORTS
            interests.Add(new Interest(201, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(202, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(203, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(204, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(205, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(206, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(207, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(208, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(209, "", "MOVIES", "HORROR"));
            interests.Add(new Interest(210, "", "MOVIES", "HORROR"));

        //MANGAS

        //CARTOONS

        //BOOKS

        //GAMES

        //TECHNOLOGIES

        //TRAVELLING

        //OCCULTIC

        return createInterests();
    }
}
