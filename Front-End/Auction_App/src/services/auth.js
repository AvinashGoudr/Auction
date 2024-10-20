import { baseUrl } from "../constants/http-constants";
import axios from "axios";

const login = function(email,password)
{
    let response = axios.post(baseUrl+"/api/login",{email, password});
    return response;
}
const isLoggedIn = () => {
    if(sessionStorage.getItem("Token"))
        return true;
    else
        return false;
}

const getToken = () => sessionStorage.getItem("Token");
export  {login,getToken,isLoggedIn}