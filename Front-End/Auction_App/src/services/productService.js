// services/productService.js
import axios from "axios";

export const getProducts = async () => {
  try {
    const response = await axios.get(
      "https://localhost:7293/api/Product/GetProducts"
    );
    if (response.data.code === 0) {
      return response.data.data; // Returning the list of products
    } else {
      console.error("Failed to fetch products");
      return [];
    }
  } catch (error) {
    console.error("Error fetching products:", error);
    return [];
  }
};
