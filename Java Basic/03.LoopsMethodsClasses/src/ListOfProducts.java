import java.io.*;
import java.util.*;

/**
 * List of Products
 * Create a class Product to hold products, which have name (string)
 * and price (decimal number). Read from a text file named "Input.txt"
 * a list of products. Each product will be in format name + space + price.
 * You should hold the products in objects of class Product.
 * Sort the products by price and write them in format price +
 * space + name in a file named "Output.txt".
 * Ensure you close correctly all used resources.
 */

public class ListOfProducts {

    static class Product  {
        private String name;
        private double price;

        public Product(String name, double price) {
            this.name = name;
            this.price = price;
        }
    }

    static void insertionSort(ArrayList<Product> arr) {
        for (int i = 1; i < arr.size(); i++) {
            Product key = arr.get(i); // element to be sorted
            int sortedIndex = i - 1; // first element

            while ((sortedIndex >= 0) && (arr.get(sortedIndex).price > key.price)) {
                arr.set(sortedIndex + 1, arr.get(sortedIndex));
                sortedIndex--;
            }
            arr.set(sortedIndex + 1, key);
        }
    }

    public static void main(String[] args) throws IOException {
        ArrayList<Product> products = new ArrayList<>();

        try (BufferedReader br =
            new BufferedReader(new FileReader("productsList.txt"))) {
            String line;

            while ((line = br.readLine()) != null) {
                String[] current = line.split(" ");
                products.add(new Product(current[0], Double.parseDouble(current[1])));
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        insertionSort(products);

        try (PrintWriter pw =
            new PrintWriter(new BufferedWriter(new FileWriter("output.txt")))) {
            for (Product p : products)
                pw.printf("%s %.2f\n", p.name, p.price);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
