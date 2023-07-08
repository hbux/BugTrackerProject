import axios from 'axios';
import storageProvider from './storageProvider';

// create axios instance
const axiosInstance = axios.create({
  baseURL: import.meta.env.VITE_API_ENDPOINT
});

// set default Authorization header
let user = storageProvider.getUser();

if (user) {
  axiosInstance.defaults.headers.common['Authorization'] = `Bearer ${user.access_token}`;
}

// export axios instance
export default axiosInstance;