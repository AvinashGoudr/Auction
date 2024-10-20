import "../assests/css/custom.css";
import { useState } from "react";
import { login } from "../services/auth";
import { Link } from "react-router-dom";
import { useHistory } from "react-router-dom";
import { useDispatch } from "react-redux";
import { getUsers } from "../services/userservice";
import { setCustomer } from "../store/customer-state";
import { useEffect } from "react";

function Login() {
  let [user, setUser] = useState({});
  let navigate = useHistory();
  let dispath = useDispatch();
  let [authStatus, setAuthStatus] = useState(true);

  useEffect(() => {
    let response = getUsers();
    response.then((d) => {
      setUser(d.data);
    });
  }, []);

  function onLogin() {
    login(user.email, user.password)
      .then((d) => {
        dispath(setCustomer(d.data));
        navigate.push("/home");
      })
      .catch((error) => setAuthStatus(false));
  }

  return (
    <div className="row vh-100">
      <div className="login-background">
        <div className="text-center mt-4 mb-3">
          <h2 className="text-light">Welcome To Auction</h2>
        </div>
        <div className="d-flex justify-content-center">
          <div className="card w-50 mt-4 mb-5 bg-info bg-opacity-10">
            <div className=" text-center">
              <div className="card-header mt-4">
                <div className="col-md-12 text-white ">
                  <i className="bi bi-person-circle fs-1"></i>
                </div>
              </div>
              <div className="m-4">
                {!authStatus && (
                  <div className="alert alert-danger text-center">
                    Login Failed
                  </div>
                )}
                <div className="card-body mt-5">
                  <div className="input-group">
                    <span className="input-group-text">
                      <i className="bi bi-person-circle"></i>
                    </span>
                    <input
                      type="Email"
                      placeholder="Email"
                      className="form-control"
                      onChange={(e) => {
                        setUser({ ...user, email: e.target.value });
                      }}
                    />
                  </div>

                  <div className="input-group mt-5 mb-4 ">
                    <span className="input-group-text">
                      <i className="bi bi-file-lock2"></i>
                    </span>
                    <input
                      type="Password"
                      placeholder="Password"
                      className="form-control w-25"
                      onChange={(e) => {
                        setUser({ ...user, password: e.target.value });
                      }}
                    />
                  </div>
                </div>
                <div className="card-footer mb-3 mt -4 ">
                  <Link to="/product">
                    {" "}
                    <button
                      type="submit"
                      className="form-control btn btn-light w-50"
                      onClick={() => onLogin()}
                    >
                      <b>Login</b>
                    </button>{" "}
                  </Link>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Login;
