import { configureStore } from "@reduxjs/toolkit";
import customerStateReducer from '../store/customer-state';

export default configureStore({
    reducer:{
        customer : customerStateReducer
    }
})

