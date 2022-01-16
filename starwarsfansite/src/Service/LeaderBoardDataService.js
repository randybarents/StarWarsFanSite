import axios from "axios";

const Quiz_API_URL = 'https://localhost:44390/LeaderBoard/'

class LeaderBoardDataServices
{
        GetHighScores()
        {
            return axios.get(`${Quiz_API_URL}GetHighScores`)
        }
}

export default new LeaderBoardDataServices()