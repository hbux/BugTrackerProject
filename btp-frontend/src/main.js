import { createApp } from 'vue'
import App from './App.vue'
import router from './router'

// third-party services
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap';

// required services
import './assets/main.css';

const app = createApp(App)

// middleware
app.use(router)

app.mount('#app')
