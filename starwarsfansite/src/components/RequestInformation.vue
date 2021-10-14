<template>
    <div>
        <input v-model="message" placeholder="enter a number from 1 to 6">
        <select v-model="selected">
        <option disabled value="">Please select one</option>
        <option>films</option>
        </select>
        <button type="submit">
            Submit movie request
        </button>
        <p>test</p>
    </div>
</template>

<script>
export default {
  name: 'RequestInformation',
  props: {
    msg: String
  }
}
</script>

