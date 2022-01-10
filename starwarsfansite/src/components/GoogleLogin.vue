<template>
  <head>
    <meta name="google-signin-scope" content="profile email" />
    <meta
      name="google-signin-client_id"
      content="1049058407193-uuumcqg6fmltgd2qpr0mds9u4d6ci6em.apps.googleusercontent.com"
    />
  </head>
  <body>
    <div class="g-signin2" data-onsuccess="onSignIn" data-theme="dark">{{profile.user}}</div>
  </body>
</template>

<script>
export default {
  mounted() {
    let externalScript = document.createElement("script");
    externalScript.setAttribute(
      "src",
      "https://apis.google.com/js/platform.js"
    );
    document.head.appendChild(externalScript);
  },
  data: () => ({}),
  methods: {
    onSignIn: function (googleUser) {
      var profile = googleUser.getBasicProfile();
      console.log(profile)

      var id_token = googleUser.getAuthResponse().id_token;
      console.log(id_token);
    },
        OnGoogleAuthFail (error) {
      console.log(error)
    },
  },
};
</script>
