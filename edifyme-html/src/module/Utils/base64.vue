<template>
  <el-form label-width="80px">
    <el-form-item label="输入" >
      <el-input type="textarea" :autosize="{ minRows: 2, maxRows: 8}"  v-model="content"></el-input>
    </el-form-item>
    <el-form-item>
      <el-button @click="base64Encode" type="primary">解码</el-button>
      <el-button @click="base64Decode" type="primary">转码</el-button>
    </el-form-item>
    <el-form-item label="输出" >
      <el-input type="textarea" :autosize="{ minRows: 2, maxRows: 8}" v-model="outPut"></el-input>
    </el-form-item>
  </el-form>
</template>

<script>
export default {
  name: 'base64',
  data() {
    return {
      content: '',
      outPut: ''
    }
  },
  mounted: function() {},
  methods: {
    base64Encode: function() {
      
    },
    base64Decode: function() {
      
    }
  }
}
</script>

<style>
</style>
