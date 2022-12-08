import axios from "axios";

const api = axios.create({
    baseURL: 'http://localhost:40713/',
});

export default api;