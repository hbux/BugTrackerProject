<script>
export default {
    name: 'errorMessage',
    props: ['message', 'validationErrors']
}
</script>

<template>
    <div v-if="message" class="alert alert-danger align-items-center w-100" role="alert">
        <div class="d-flex align-items-center">
            <svg class="bi flex-shrink-0 me-2" width="16" height="16" role="img" aria-label="Danger:"><use xlink:href="#exclamation-triangle-fill"/></svg>
            <div>
                {{ message }}
            </div>
        </div>
        <ul v-if="validationErrors" class="pt-2 m-0">
            <li v-for="error in validationErrors">{{ error.message }}</li>
        </ul>
    </div>
</template>