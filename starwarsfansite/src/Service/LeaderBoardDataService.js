import axios from "axios";

const People_API_URL = 'https://localhost:44390/LeaderBoard/'

class LeaderBoardDataServices
{
        GetHighScores()
        {
            return axios.get(`${People_API_URL}GetHighScores`)
        }
}

export default new LeaderBoardDataServices()