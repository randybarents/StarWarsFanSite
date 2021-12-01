import axios from "axios";

const People_API_URL = 'https://localhost:44366/people'

class PeopleDataServices
{
        GetPersonById(id)
        {
            return axios.get(`${People_API_URL}/${id}`)
        }

        GetAllPeople()
        {
            return axios.get(`${People_API_URL}`)
        }
}

export default new PeopleDataServices()