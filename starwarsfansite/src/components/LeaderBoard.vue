<template>
<div id="app" class="col-sm-12">
  <div class="infotable">
  <table border=10 class="datatable">
    <thead>
      <tr>
        <th>Username</th>
        <th>Score</th>
      </tr>
    </thead>
    <tbody>
    <tr v-for="item in res.data" :key="item.Username">
      <td>{{item.username}}</td>
      <td>{{item.score}} out of 10</td>
    </tr>
    </tbody>
  </table>
  </div>
</div>
</template>

<script>
import LeaderBoardDataSevice from "../Service/LeaderBoardDataService";

export default {
  name: "GetLeaderBoard",
  components: {

  },
  data: () => ({
    res: ""
  }),
  methods: {
    async GetLeaderBoard() {
      this.res = await LeaderBoardDataSevice.GetHighScores();
    },
  },
  mounted()
  {
    this.GetLeaderBoard();
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

</style>