<template>
    <div class="RequestInformation">
      <input v-model="message" placeholder="enter a number from 1 to 6">
      <select v-model="selected">
      <option disabled value="">Please select one</option>
      <option>films</option>
      </select>
      <div>
      <button class="btn btn-primary" v-on:click="getInfo">Get entity information</button>
      </div>
    </div>
    <div id="app">
    {{ apiInfo }}
    </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'RequestInformation',
  props: {
    msg: String
  },
  methods: {
    async getInfo()
    {
      const info = await axios
      .get('https://localhost:44366/Film')
      .then((result) => {return result.data;});
      this.apiInfo = info;
    }
  }
}
</script>
