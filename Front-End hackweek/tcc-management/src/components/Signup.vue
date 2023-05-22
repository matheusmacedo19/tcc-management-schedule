<template>
<form @submit.prevent="validar">
    <!-- Name input -->
  <div class="form-outline mb-4">
    <label class="form-label" for="form2Example4">Nome</label>
    <input type="name" v-model="signup.nome" id="form4Example4" class="form-control" />
  </div>

     <!-- Tipo input -->
  <div class="form-outline mb-4">
    <label class="form-label" for="form2Example5">Tipo Usuario</label>
       <select class="form-select " v-model="signup.tipo" id="form2Example5">
        <option selected></option>
        <option value="1">Estudante</option>
        <option value="2">Orientador</option>
        <option value="3">Coordenação</option>
      </select>
  </div>

  <!-- Email input -->
  <div class="form-outline mb-4">
    <label class="form-label" for="form2Example1">Email</label>
    <input type="email" v-model="signup.email" id="form2Example1" class="form-control" />
  </div>

  <!-- Password input -->
  <div class="form-outline mb-4">
    <label class="form-label" for="form2Example2">Senha</label>
    <input type="password" v-model="signup.senha" id="form2Example2" class="form-control" />
  </div>

  <!-- Password 2 input -->
  <div class="form-outline mb-4">
    <label class="form-label" for="form2Example3">Confirmar Senha</label>
    <input type="password" v-model="signup.senha2" id="form2Example3" class="form-control" />
  </div>
  <!-- Submit button -->
  <button type="submit" class="btn btn-primary btn-block mb-4">Sign up</button>
</form>
</template>

<script>
import api from "../services/api.js";
export default {
  name: "FormSignup",
  data() {
    return {
      signup: {
        nome: "",
        email: "",
        tipo: "",
        senha: "",
      },
    };
  },
  methods: {
    cadastrar() {
      api.post("api/CreateUser/", this.signup).then((Response) => {
        alert("Usuario cadastrado com sucesso");
      });
    },
    validar() {
      if (
        this.signup.nome == "" ||
        this.signup.email == "" ||
        this.signup.tipo == "" ||
        this.signup.senha == "" ||
        this.signup.senha2 == ""
      ) {
        alert("Os campos nao podem ficar vazios.");
      } else if (this.signup.senha.length < 6) {
        alert("Senha precisa ter 6 digitos.");
      } else if (this.signup.senha != this.signup.senha2) {
        alert("As senhas não são iguais! Tente novamente.");
      } else {
        this.cadastrar();
      }
    },
  },
};
</script>