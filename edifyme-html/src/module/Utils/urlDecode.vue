<template>
  <el-form label-width="80px">
    <el-form-item label="UrlEncode" >
      <el-input type="textarea" :autosize="{ minRows: 2, maxRows: 8}"  v-model="encodeContent"></el-input>
    </el-form-item>
    <el-form-item>
      <el-button @click="decode" type="primary">Decode</el-button>
    </el-form-item>
    <el-form-item label="UrlDecode" >
      <el-input type="textarea" :autosize="{ minRows: 2, maxRows: 8}" v-model="decodeContent"></el-input>
    </el-form-item>
  </el-form>
</template>

<script>
export default {
  name: 'utilGuid',
  data() {
    return {
      encodeContent: '',
      decodeContent: ''
    }
  },
  mounted: function() {},
  methods: {
    decode: function() {
      this.decodeContent = decodeURI(this.encodeContent)
    }
  }
}
</script>

<style>
</style>
