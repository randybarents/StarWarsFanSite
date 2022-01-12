<template>
<div id="app" class="col-sm-12">
  <div class="infotable">
  <table border=10 class="datatable">
    <thead>
      <tr>
        <th>Name</th>
        <th>Height in cm</th>
        <th>Mass in kg</th>
        <th>More information</th>
      </tr>
    </thead>
    <tbody>
    <tr v-for="item in results" :key="item.name">
      <td>{{item.name}}</td>
      <td>{{item.height}}</td>
      <td>{{item.mass}}</td>
      <td><button type="button" class="showBtn" @click="showModal">
      Click here
      </button></td>
    </tr>
    </tbody>
    <button type="button" @click="PreviousPage" v-if="pageNumber !=1" class="numberBtnPrev"> Previous </button>
    <button type="button" @click="NextPage" v-if="pageNumber !=9" class="numberBtnNext"> Next </button>
  </table>
  </div>
</div>
</template>

<script>
import PeopleDataService from "../Service/PeopleDataService";

export default {
  name: "GetPeopleInformation",
  components: {},
  data: () => ({
    pageNumber: 1,
    res: "",
    results: []
  }),
  methods: {
    async GetPeoplePaginated() {
      this.res = await PeopleDataService.GetPeoplePaginated(this.pageNumber);
      this.results = this.res.data.results;
    },
    async NextPage()
    {
      if(this.pageNumber < 9)
      {
        this.pageNumber++;
      }
    },
        async PreviousPage()
    {
      if(this.pageNumber  > 1)
      {
        this.pageNumber--;
      }
    }
  },
  watch: {
    pageNumber: function()
    {
      this.GetPeoplePaginated(this.pageNumber);
    }
  },
  mounted()
  {
    this.GetPeoplePaginated();
  },
};
</script>

<style scoped>

.datatable{
  margin-left: auto;
  margin-right: auto;
  border-spacing: 1cm;
  color: #FFE81F;
}

.showBtn{
  background-color: #FFE81F;
  border: none;
  color: black;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
}

.numberBtnPrev{
  background-color: #FFE81F;
  border: none;
  color: black;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  
}

.numberBtnNext{
  background-color: #FFE81F;
  border: none;
  color: black;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin-left: 20px;
}

</style>