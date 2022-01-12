<template>
  <div class="GetAllPeoplePaginated">
    </div>
</template>





<script>
import PeopleDataService from "../Service/PeopleDataService";

export default {
  name: "GetPeopleInformation",
  components: {},
  data: () => ({
    pageNumber: "",
    res: "",
  }),
  methods: {
    async GetPeoplePaginated() {
      this.res = await PeopleDataService.GetPeoplePaginated(this.pageNumber);
    },

  },
};
</script>