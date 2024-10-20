import { baseUrl } from "../constants/http-constants";
import axios from 'axios';


export const addNewAdmin= (user) => {
    return axios.post(`${baseUrl}/api/user`,user);
   
} 

export const getAdminById = (id) => {
    return axios.get(`${baseUrl}/api/user/${id}`);
}

export const updateAdmin = (user) => {
    return axios
            .put(`${baseUrl}/api/user`,user);
}

export const deleteAdmin = (id) => {
    return axios
            .delete(`${baseUrl}/api/user/${id}`,id);
}
