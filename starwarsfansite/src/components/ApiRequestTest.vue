<script>
import axios from 'axios';

export default {
  name: "get-request",
  data() {
    return {
      totalVuePackages: null
    };
  },
    created() {
  // Simple GET request using axios
  axios.get("https://swapi.dev/api/starships/9/")
    .then(response => this.totalVuePackages = response.data.total);
    }
}
</script>