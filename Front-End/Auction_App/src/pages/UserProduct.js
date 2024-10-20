import React, { useEffect, useState } from "react";
import axios from "axios";
import AppNavBar from "../layouts/app-nav-bar";
import Footer from "../layouts/footer";
function UserProduct() {
  const [products, setProducts] = useState([]);
  const userId = 1; // Assuming you are fetching for user with ID 1

  // Fetch products by userId from the API
  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const response = await axios.get(
          `https://localhost:7293/api/Product/GetProductsByUserId`,
          {
            params: { userId },
          }
        );

        if (response.data && response.data.code === 0) {
          setProducts(response.data.data); // Store the product data in state
        } else {
          console.error("Failed to fetch products");
        }
      } catch (error) {
        console.error("Error fetching products:", error);
      }
    };

    fetchProducts();
  }, [userId]);

  return (
    <>
      <AppNavBar></AppNavBar>
      <div className="container mt-5">
        <h2>User Products</h2>

        <table className="table table-bordered">
          <thead>
            <tr style={{ backgroundColor: "#d4f1f9" }}>
              <th>ID</th>
              <th>Name</th>
              <th>Description</th>
              <th>Starting Price</th>
              <th>Current Price</th>
              <th>End Date</th>
            </tr>
          </thead>
          <tbody>
            {products.length > 0 ? (
              products.map((product) => (
                <tr key={product.id}>
                  <td>{product.id}</td>
                  <td>{product.name}</td>
                  <td>{product.description}</td>
                  <td>{product.staringPrice}</td>
                  <td>{product.currentPrice}</td>
                  <td>{new Date(product.endDate).toLocaleString()}</td>
                </tr>
              ))
            ) : (
              <tr>
                <td colSpan="6" className="text-center">
                  No products found
                </td>
              </tr>
            )}
          </tbody>
        </table>
      </div>
      <Footer></Footer>
    </>
  );
}

export default UserProduct;
