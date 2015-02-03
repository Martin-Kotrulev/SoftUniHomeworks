import java.util.*;
/**
 * Full House
 * In most Poker games, the "full house" hand is defined as three cards
 * of the same face + two cards of the same face, other than the first,
 * regardless of the card's suits. The cards faces are
 * "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" and "A".
 * The card suits are "♣", "♦", "♥" and "♠". Write a program to
 * generate and print all full houses and print their number.
 *
 * TODO: fix major bug with the adding combination to the collection
 * Note: on debugging the elements is added correctly. Strange bug occurs:
 * the elements is all aces in the end
 * */

 public class FullHouseGenerator {
    private static int fullHouses = 0;
    private static HashSet<TreeSet> added = new HashSet<>();
    private static ArrayList<String[]> threes = new ArrayList<> ();
    private static ArrayList<String[]> pairs = new ArrayList<>();

    private static void buildDeck (ArrayList<String> cards) {
        char[] suits = {'\u2663', '\u2666', '\u2665', '\u2660'};
        for (int i = 2; i <= 14; i++) {
            for (int j = 0; j < suits.length; j++) {
                if (i < 10) cards.add("" + i + suits[j]);
                else {
                    switch (i) {
                        case 10:
                            cards.add("T" + suits[j]); // 10 is T for clearness
                        case 11:
                            cards.add("J" + suits[j]);
                            break;
                        case 12:
                            cards.add("Q" + suits[j]);
                            break;
                        case 13:
                            cards.add("K" + suits[j]);
                            break;
                        case 14:
                            cards.add("A" + suits[j]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    private static void permutate(ArrayList<String> cards, String[] comb, int p) {
        // recursively building the cards combinations
        if (p == comb.length) {
            checkCombination(comb);
            return;
        }

        for (int j = 0; j < cards.size(); j++){
            comb[p] = cards.get(j);
            permutate(cards, comb, p + 1);
        }
    }

    private static void checkCombination(String[] comb) {
        if(comb.length == 3) {
            // check if the three faces are same and suits are not
            if ((comb[0].charAt(0) == comb[1].charAt(0) && comb[1].charAt(0) == comb[2].charAt(0)) &&
                    (comb[0].charAt(1) != comb[1].charAt(1) && comb[0].charAt(1) != comb[2].charAt(1) &&
                            comb[1].charAt(1) != comb[2].charAt(1))) {
                addCombination(comb);
            }
        } else {
            // check if the pair faces are same and suits are not
            if (comb[0].charAt(0) == comb[1].charAt(0) &&
                    comb[0].charAt(1) != comb[1].charAt(1)) {
                addCombination(comb);
            }
        }
    }

    private static void addCombination(String[] comb) {
        // adding only combinations that are not already added
        TreeSet<String> current;
        if (comb.length == 3) {
            current = new TreeSet<>();
            current.add(comb[0]);
            current.add(comb[1]);
            current.add(comb[2]);
            if (!added.contains(current)) {
                threes.add(comb);
            }
        } else {
            current = new TreeSet<>();
            current.add(comb[0]);
            current.add(comb[1]);
            if (!added.contains(current)) {
                pairs.add(comb);
            }
        }
        added.add(current);
    }

    private static void printCombinations(ArrayList<String[]> threes, ArrayList<String[]> pairs) {
        for (int i = 0; i < threes.size(); i ++) {
            String[] three = threes.get(i);

            for (int j = 0; j < pairs.size(); j++) {
                String[] pair = pairs.get(i);

                if (three[0].equals(pair[0])) continue;

                System.out.printf("(%s%s%s%s%s)\n",
                        three[0],
                        three[1],
                        three[2],
                        pair[0],
                        pair[1]);
            }
        }
    }

    public static void main(String[] args){
        ArrayList<String> cards = new ArrayList<>();
        String[] threeCombination = new String[3];
        String[] pairCombination = new String[2];

        buildDeck(cards);

        permutate(cards, threeCombination, 0);
        permutate(cards, pairCombination, 0);


        printCombinations(threes, pairs);

        /* you can't have three of a kind AND a pair of the same type
        so, 13 types of three of a kind with 12 types of pairs = 52 * 72 */
        fullHouses = (pairs.size() - 6) * threes.size();
        System.out.println(fullHouses);
    }


}
