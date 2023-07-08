<script>
export default {
    name: 'successMessage',
    props: ['message']
}
</script>

<template>
    <div v-if="message" class="alert alert-success d-flex align-items-center w-100" role="alert">
        <svg class="bi flex-shrink-0 me-2" width="16" height="16" role="img" aria-label="Danger:"><use xlink:href="#check-circle-fill"/></svg>
        <div>
            {{ message }}
        </div>
    </div>
</template>