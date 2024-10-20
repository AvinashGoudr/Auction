// components/ProductCard.js
import React from "react";
import { Card, Button, Badge } from "react-bootstrap";

const ProductCard = ({ product }) => {
  return (
    <Card className="m-2" style={{ width: "18rem" }}>
      <Card.Img
        variant="top"
        src={product.image ? product.image : "https://via.placeholder.com/150"}
        alt={product.name}
        style={{ width: "100%", height: "200px", objectFit: "cover" }} // Fixed size and cover scaling
      />

      <Card.Body>
        <Badge pill bg="success">
          Live Auction
        </Badge>
        <Card.Title>{product.name}</Card.Title>
        <Card.Text>
          <strong>Description:</strong>{" "}
          {product.description.length > 35
            ? product.description.substring(0, 35) + "..."
            : product.description}{" "}
          <br />
          <strong>Minimum Bid:</strong> ₹{product.staringPrice} <br />
          <strong>Current Bid:</strong> ₹{product.currentPrice} <br />
          <strong>Bid End Date:</strong>{" "}
          {new Date(product.endDate).toLocaleString()}
        </Card.Text>

        <Button variant="primary">Bid now</Button>
      </Card.Body>
    </Card>
  );
};

export default ProductCard;
