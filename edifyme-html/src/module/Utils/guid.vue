<template>
  <el-form label-width="80px">
    <el-form-item label="Guid" >
      <el-col :span="16">
      <el-input v-model="content"></el-input>
      </el-col>
      <el-button @click="generate" type="primary">生成</el-button>
    </el-form-item>
  </el-form>
</template>

<script>
export default {
  name: 'utilGuid',
  data() {
    return {
      content: ''
    }
  },
  mounted: function() {},
  methods: {
    generate: function() {
      this.$axios
        .get('api/Utils/GuidGenerate')
        .then(resp => {
          console.log(resp)
          this.content = resp.data
        })
        .catch(err => {
          console.log(err)
        })
    }
  }
}
</script>

<style>
</style>
