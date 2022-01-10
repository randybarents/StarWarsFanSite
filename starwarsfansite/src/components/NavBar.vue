<template>
  <nav>
      <ul class="navBar">
          <li><a href="">Home</a></li>
          <li><a href="/GetSinglePerson">People Information</a></li>
          <li><a href="">Start Quiz</a></li>
          <!-- <GoogleLogin></GoogleLogin> -->
      </ul>
  </nav>
</template>

<script>
// import GoogleLogin from '../components/GoogleLogin.vue'

export default {
    name: 'Navbar',
    components: {
      // GoogleLogin
    }
}
</script>

<style>
ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #20242b;
}

li {
  float: left;
  display: inline;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

li a:hover {
  background-color: #4b66c5;
  color: rgb(0, 0, 0);
}
</style>