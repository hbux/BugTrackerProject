<script>
import ErrorMessage from '../../components/ErrorMessage.vue';

export default {
    name: 'createProject',
    components: {
        ErrorMessage
    }
}
</script>

<template>
    <div class="container-fluid container p-4">
        <ErrorMessage message="" validationErrors=""/>
        <div class="pt-2 pb-3 mb-3 border-bottom">
            <a class="link-dark text-decoration-none" style="background-color: white;">
                <span class="fs-5 fw-semibold">Create project</span>
            </a>
            <p class="text-muted m-0 pt-2">Create a new project for your work, 
                collaboratively track progress of an ongoing project, supporting users, roles, permissions
            </p>
        </div>
        <form class="row g-3">
            <div class="col-md-3">
                <label for="inputOwner" class="form-label">Owner <span class="text-danger">*</span></label>
                <input class="form-control" type="text" aria-label="Disabled input example" disabled>
            </div>
            <div class="col-md-9">
                <label for="inputProject" class="form-label">Project name <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="inputProject">
                <div class="form-text" id="basic-addon4">Give your project a meaningful name that is unique to your account.</div>
            </div>
            <div class="col-12 mb-3">
                <label for="inputDescription" class="form-label">Description</label>
                <textarea class="form-control" id="inputDescription" rows="3"></textarea>
            </div>
            <div class="col-12 mb-1">
                <div class="d-flex align-items-center border-top border-bottom py-3">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-info-circle me-2" viewBox="0 0 16 16">
                        <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
                        <path d="m8.93 6.588-2.29.287-.082.38.45.083c.294.07.352.176.288.469l-.738 3.468c-.194.897.105 1.319.808 1.319.545 0 1.178-.252 1.465-.598l.088-.416c-.2.176-.492.246-.686.246-.275 0-.375-.193-.304-.533L8.93 6.588zM9 4.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
                    </svg>
                    <small>You will be assigned to the role of <strong>Owner</strong>. Ownership can be transferred at any time.</small>
                </div>
            </div>
            <div class="col-12">
                <button type="submit" class="btn btn-success">Create project</button>
            </div>
        </form>
    </div>
</template>

<style scoped>
.form-control, .btn, .alert {
    border-radius: 0.15rem;
    transition: none;
}
</style>