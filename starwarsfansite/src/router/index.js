import { createWebHistory, createRouter } from "vue-router";
import GetSinglePerson from './../components/GetSinglePerson'
import HomePage from './../components/HomePage'

const routes = [
    {
      path: "/GetSinglePerson",
      name: "GetSinglePerson",
      component: GetSinglePerson,
    },
  ];
  
  const router = createRouter({
    history: createWebHistory(),
    routes,
  });
  
  export default router;