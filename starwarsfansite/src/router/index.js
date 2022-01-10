import { createWebHistory, createRouter } from "vue-router";
import GetSinglePerson from './../components/GetSinglePerson'
import GetAllPeoplePaginated from './../components/GetAllPeoplePaginated'
import HomePage from './../components/HomePage'

const routes = [
    {
      path: "/GetSinglePerson",
      name: "GetSinglePerson",
      component: GetSinglePerson,
    },
    {
      path: "/GetAllPeoplePaginated",
      name: "GetAllPeoplePaginated",
      component: GetAllPeoplePaginated,
    },
  ];
  
  const router = createRouter({
    history: createWebHistory(),
    routes,
  });
  
  export default router;