<template>
  <div class="Quiz">
    <h1 style="color: yellow">Test your knowledge</h1>
    <div class="QuestionCards">
      <div class="container" id="app">
    <div class="row">
        <div v-for="item in res.data" :key="item.questions.questionString" class="col-md-3 col-6 my-1">
            <div class="card">
                <div class="card-body">
                    <div class="card_name">{{ item.questions.questionString }}</div>
                    <div class="card_answers">
                        <p>{{ item.answers[0].answerString }}</p>
                        <p>{{ item.answers[1].answerString }}</p>
                        <p>{{ item.answers[2].answerString }}</p>
                        <p>{{ item.answers[3].answerString }}</p>
                    </div>
                </div>
            </div>
        </div> 
    </div>
</div>
    </div>
  </div>
</template>

<script>
import QuizDataService from "../Service/QuizDataService";

export default {
  name: "LoadQuiz",
  components: {
  },
  data: () => ({
    res: "",
    selectedAnswer: "",
    correctAnswers: 0,
  }),
  methods: {
    async LoadQuiz() {
      this.res = await QuizDataService.LoadQuiz();
    },
  },
  mounted() {
    this.LoadQuiz();
  },
};
</script>

<style scoped>
.card {
  background-color: #2c2f33;
  color: #262729;
  border-radius: 50px;
  padding: 20px;
  width: 500px;
  font-size: 25px;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 10px;
}

.card_name {
  color: #ffe81f;
  margin-bottom: 10px;
}

.card_answers {
  color: #ccc055;
  font-size: 20px;
  overflow-wrap: break-word;
}
</style>
