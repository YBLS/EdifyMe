<template>
  <el-container>
    <el-header>
      <h1>工具类</h1>
    </el-header>
    <el-main>
    <el-tabs v-model="tabsAction" @tab-click="handleTabs">
      <el-tab-pane label="Url Decode" name="first">
        <util-urldecode></util-urldecode>
      </el-tab-pane>
      <el-tab-pane label="Guid 生成" name="second">
        <util-guid></util-guid>
      </el-tab-pane>
    </el-tabs>
    </el-main>
  </el-container>
</template>

<script>
import utilGuid from './guid.vue'
import utilUrldecode from './urlDecode.vue'
export default {
  name: 'util',
  data() {
    return {
      tabsAction: 'first'
    }
  },
  components: { utilGuid, utilUrldecode },
  methods: {
    handleTabs: function(tab, event) {
      console.log(tab, event)
    }
  }
}
</script>

<style>
</style>
