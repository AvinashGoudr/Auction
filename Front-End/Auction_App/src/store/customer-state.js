import { createSlice } from "@reduxjs/toolkit";

export const customerState = 
createSlice({
    name : "cart",
    initialState : {
        customer : null
    },
    reducers : {
        setCustomer : (state,action) =>{
            sessionStorage.setItem("Token",action.payload);
            state.customer = action.payload;
        },
        logoutCustomer : (state,action) => {
            state.customer = null;  
            sessionStorage.removeItem("Token");
        }
    }

});

export const {setCustomer,logoutCustomer} = customerState.actions;
export default customerState.reducer;