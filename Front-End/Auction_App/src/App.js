import { Route, Switch } from "react-router-dom";
import Login from "./pages/Login";
import { GuardProvider, GuardedRoute } from "react-router-guards";
import { isLoggedIn } from "./services/auth";
import ProductsPage from "./pages/Product";
import UserProducts from "./pages/UserProduct";

let checkIsUserLoggedIn = (to, from, next) => {
  if (isLoggedIn()) {
    next();
  } else next.redirect("/");
};

function App() {
  return (
    <div className="App">
      <GuardProvider guards={[checkIsUserLoggedIn]}>
        <Switch>
          <Route path="/" component={Login} exact></Route>
          <Route path="/product" component={ProductsPage} exact></Route>
          <Route path="/UserProducts" component={UserProducts} exact></Route>
        </Switch>
      </GuardProvider>
    </div>
  );
}

export default App;
