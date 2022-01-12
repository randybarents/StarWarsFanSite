import { createWebHistory, createRouter } from "vue-router";
import GetSinglePerson from './../components/GetSinglePerson'
import GetAllPeoplePaginated from './../components/GetAllPeoplePaginated'
import Quiz from './../components/Quiz'

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
    {
      path: "/Quiz",
      name: "Quiz",
      component: Quiz,
    },
  ];
  
  const router = createRouter({
    history: createWebHistory(),
    routes,
  });
  
  export default router;