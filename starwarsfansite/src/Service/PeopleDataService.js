import axios from "axios";

const People_API_URL = 'https://localhost:44366/people'
const Paginated_People_API_URL = 'https://localhost:44366/peoples'

class PeopleDataServices
{
        GetPersonById(id)
        {
            return axios.get(`${People_API_URL}/${id}`)
        }

        GetAllPeoplePaginated()
        {
            return axios.get(`${Paginated_People_API_URL}/${id}`)
        }
}

export default new PeopleDataServices()