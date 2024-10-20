import "react-bootstrap";
import { Navbar, Nav } from "react-bootstrap";
import { useSelector, useDispatch } from "react-redux";
import { logoutCustomer } from "../store/customer-state";
import { Link } from "react-router-dom";

function AppNavBar() {
  let dispatch = useDispatch();
  let customer = useSelector((state) => state.customer);

  return (
    <Navbar className="header" expand="lg">
      <Navbar.Brand href="#home" className="ms-5 me-5">
        <span>
          <i className="bi bi-hammer fs-1" style={{ color: "white" }}></i>
          <span className="fs-3 ms-2 mt-5 text-light">Auction</span>
        </span>
      </Navbar.Brand>
      <Navbar.Toggle aria-controls="basic-navbar-nav" />
      <Navbar.Collapse id="basic-navbar-nav" className="me-5">
        <div className="d-flex justify-content-between w-100">
          <Nav className="d-flex">
            <Nav.Link href="/product" className="text-light fs-5">
              <i className="bi bi-emoji-smile me-1 rounded-5"></i>Home
            </Nav.Link>
            <Nav.Link href="/UserProducts" className="text-light fs-5">
              <i className="bi bi-border-width me-1 rounded-5"></i>My Products
            </Nav.Link>
          </Nav>
          <div className="text-end">
            <Link to="/">
              <button
                type="button"
                onClick={() => {
                  dispatch(logoutCustomer());
                }}
                className="btn btn-light text-dark"
              >
                Log Out
              </button>
            </Link>
          </div>
        </div>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default AppNavBar;
