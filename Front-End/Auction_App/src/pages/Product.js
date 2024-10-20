// components/ProductsPage.js
import React, { useEffect, useState } from "react";
import { Container, Row, Col } from "react-bootstrap";
import { getProducts } from "../services/productService"; // Import the service
import ProductCard from "./ProductCard"; // The ProductCard component created earlier
import AppNavBar from "../layouts/app-nav-bar"; // NavBar

const ProductsPage = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    // Fetch the product data when the component mounts
    const fetchProducts = async () => {
      const data = await getProducts();
      setProducts(data);
    };

    fetchProducts();
  }, []);

  return (
    <>
      <AppNavBar />
      <Container>
        <h1 className="mt-3 mt-1 text-center">
          Welcome Auction!
        </h1>
        <Row>
          {products.length > 0 ? (
            products.map((product) => (
              <Col key={product.id} sm={12} md={6} lg={4} xl={3}>
                <ProductCard product={product} />
              </Col>
            ))
          ) : (
            <p>No products available.</p>
          )}
        </Row>
      </Container>
    </>
  );
};

export default ProductsPage;
