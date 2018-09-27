<template>
  <el-container>
    <el-main>
      <util></util>
    </el-main>
    <el-footer>版本权所有:  ..........</el-footer>
  </el-container>
</template>

<script>
import Util from '../Utils/index.vue'
export default {
  name: 'home',
  components: { Util },
  mounted: function() {},
  methods: {}
}
</script>

<style>
.el-footer {
  position: absolute;
  bottom: 0;
  width: 100%;
}
</style>

