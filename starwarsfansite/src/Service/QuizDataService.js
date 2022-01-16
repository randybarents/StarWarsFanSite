import axios from "axios";

const Quiz_API_URL = 'https://localhost:44390/Quiz/'

class LeaderBoardDataServices
{
        LoadQuiz()
        {
            return axios.get(`${Quiz_API_URL}LoadQuiz`)
        }
}

export default new LeaderBoardDataServices()