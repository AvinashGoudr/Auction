import { baseUrl } from "../constants/http-constants";
import axios from 'axios';


export const getUsers=()=>{
    return axios.get(`${baseUrl}/api/user`);
}


