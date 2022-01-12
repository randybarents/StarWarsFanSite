import { createWebHistory, createRouter } from "vue-router";
import GetSinglePerson from './../components/GetSinglePerson'
import GetAllPeoplePaginated from './../components/GetAllPeoplePaginated'
import Quiz from './../components/Quiz'
import LeaderBoard from './../components/LeaderBoard.'

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
    {
      path: "/LeaderBoard",
      name: "LeaderBoard",
      component: LeaderBoard,
    },
  ];
  
  const router = createRouter({
    history: createWebHistory(),
    routes,
  });
  
  export default router;