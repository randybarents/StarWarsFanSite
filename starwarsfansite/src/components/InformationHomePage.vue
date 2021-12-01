<template>
    <div class="RequestInformation">
      <input v-model="personId" placeholder="enter a number from 1 to 83">
      <button v-on:click="GetPersonById">Get entity information</button>
      <p>{{ this.res }}</p>
    </div>
</template>

<script>
import PeopleDataService from '../Service/PeopleDataService'

export default{
  name: "RequestPeopleInfo",
  components: {
  },
  data: () => ({
    personId: "",
    res: ""
  }),
  methods: {
    async GetPersonById()
    {
      this.res = await PeopleDataService.GetPersonById(this.personId)     
    }
  }
}
</script>
