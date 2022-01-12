import axios from "axios";

const People_API_URL = 'https://localhost:44366/People/'

class PeopleDataServices
{
        GetPersonById(id)
        {
            return axios.get(`${People_API_URL}GetPerson?Id=${id}`)
        }

        GetPeoplePaginated(pageNumber)
        {
            return axios.get(`${People_API_URL}GetPeople?pageNumber=${pageNumber}`)
        }
}

export default new PeopleDataServices()