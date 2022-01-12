import { createApp } from 'vue'
import App from './App.vue'
import router from './router/index.js'

import '@fortawesome/fontawesome-free/js/all'

createApp(App).use(router).mount('#app')
