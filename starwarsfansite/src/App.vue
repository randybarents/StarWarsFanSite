<template>
  <Sidebar />
  <div :style="{ 'margin-left': sidebarWidth }">
    <router-view />
  </div>
  <div :style="myStyle" id="wrapper"></div>
</template>

<script>
import Sidebar from './components/Sidebar.vue'
import { sidebarWidth } from './Js/state'

export default {
  name: 'App',
  components: {
    Sidebar
  },
  setup() {
    return { sidebarWidth }
  }
}
</script>

<style>
#myStyle{
  background-color: #2c3e50;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
#nav {
  padding: 30px;
}
#nav a {
  font-weight: bold;
  color: #2c3e50;
}
#nav a.router-link-exact-active {
  color: #42b983;
}

body{
  background-color: #131313;
}
</style>
