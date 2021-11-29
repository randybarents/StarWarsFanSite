<template>
    <div class="RequestInformation">
      <input v-model="personId" placeholder="enter a number from 1 to 83">
      <button v-on:click="personId">Get entity information</button>
    </div>
</template>

<script>
import PeopleData from 'DataService\PeopleDataService.js'

export default{
  name: "App",
  components: {
  },
  data: () => ({
    personId
  }),
  methods: {
    async GetPersonById()
    {
      return await PeopleData.GetPersonById(this.personId)
    }
  }
}
</script>
